using System;
using System.Collections;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DLS.Common.Frm10.DataBase
{
    public class ExecuteDataBase : DLS.Common.Frm10.DataBase.ConnectString
    {
        #region 외부에서 호출할 메서드 집합

        public static object ShowPerfCounter()
        {
            float v1 = 0;
            try
            {
                string processName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                int pid = Process.GetProcessesByName(processName)[0].Id;
                string instanceName = string.Format("{0}[{1}]", processName, pid);

                // .NET Data Provider for SqlServer 카테고리 안의
                // NumberOfPooledConnections 카운터 측정
                var counter1 = new PerformanceCounter(".NET Data Provider for SqlServer", "NumberOfPooledConnections", instanceName);
                v1 = counter1.NextValue();
            }
            catch
            {
                v1 = 0;
            }
            return v1;
        }


        //
        //1. 입력, 수정, 삭제시 반환값이 없는 쿼리 실행시.
        //
        public static int ExecNonQuery(string proc, Hashtable ht, string conn)
        {
           return new ExecuteDataBase()._ExecNonQuery(proc, ht, conn);
        }
        public static int ExecNonQuery_NoTran(string proc, Hashtable ht, string conn)
        {
            return new ExecuteDataBase()._ExecNonQuery_NoTran(proc, ht, conn);
        }

        //
        //2. 단일값(스칼라값)을 반환하는 쿼리 실행시.
        //
        public static object ExecScalarQuery(string proc, Hashtable ht, string conn)
        {
            return new ExecuteDataBase()._ExecScalarQuery(proc, ht, conn);
        }

        //
        //3. DataSet 객체를 반환하는 쿼리 실행시.
        //
        public static DataSet ExecDataSetQuery(string proc, Hashtable ht, string conn)
        {
            return new ExecuteDataBase()._ExecDataSetQuery(proc, ht, conn);
        }

        //
        //3.1 DataTable 객체를 반환하는 쿼리 실행시.
        //
        public static DataTable ExecDataTableQuery(string proc, Hashtable ht, string conn)
        {
            return new ExecuteDataBase()._ExecDataTableQuery(proc, ht, conn);
        }
        public static DataTable ExecDataTableQuery(string proc, Hashtable ht, ref Hashtable htOutput, string conn)
        {
            return new ExecuteDataBase()._ExecDataTableQuery(proc, ht, ref htOutput, conn);
        }

        //
        //3.1 DataTable 객체를 반환하는 쿼리 실행시.
        //
        public static DataTable ExecDataTableQuery_Reader(string proc, Hashtable ht, string conn)
        {
            return new ExecuteDataBase()._ExecDataTableQuery_Reader(proc, ht, conn);
        }

        //4. 싱글행 그룹을 등록할때
        //
        public static void ExecSingleRowGroupTran(Hashtable[] sGroup, string conn)
        {
            new ExecuteDataBase()._ExecNonQueryTran_SingleRowGroup(sGroup, conn);
        }
        //
        //5. 멀티행 그룹을 등록할때
        //
        public static void ExecMultiRowGroupTran(Hashtable[] mGroup, string conn)
        {
            new ExecuteDataBase()._ExecNonQueryTran_MultiRowsGroup(mGroup, conn);
        }

        //6. 싱글행그룹+멀티행그룹으로 이뤄진 복합구조를 등록할때
        //
        public static void ExecComplexTran(Hashtable[] sGroup, Hashtable[] mGroup, string conn)
        {
            new ExecuteDataBase()._ExecNonQueryTran_Complex(sGroup, mGroup, conn);
        }
        #endregion

        #region 내부에서 Run되는 메서드 집합(경고:직접사용금지!!)

        #region 단일-데이터입력,수정,삭제시사용
        private int _ExecNonQuery(string proc, Hashtable ht, string conn)
        {
            SqlConnection dbConn = null;
            SqlCommand dbComm = null;
            int rtCnt;
            SqlTransaction trans = null;
            try
            {
                dbConn = this._dbConn(dbConn, conn);
                dbComm = new SqlCommand();
                dbComm.Connection = dbConn;
                dbComm.CommandTimeout = 3000; //5분
                dbComm.CommandType = CommandType.StoredProcedure;
                dbComm.CommandText = proc;

                //파라메터 등록
                if (ht.Count > 0)
                    this._AddParam(ref dbComm, ref ht);

                //실행
                dbConn.Open();
                //트랜잭션 시작..
                trans = dbConn.BeginTransaction();
                dbComm.Transaction = trans;

                rtCnt = dbComm.ExecuteNonQuery();

                //커밋..
                trans.Commit();
                dbConn.Close();
            }
            catch (Exception ex)
            {
                //롤백..
                trans.Rollback();
                throw ex;
            }
            finally
            {
                if (dbConn.State == ConnectionState.Open || dbConn.State == ConnectionState.Connecting)
                    dbConn.Close();
            }

            return rtCnt;
        }
        #endregion
        #region 단일-데이터입력,수정,삭제시사용 Non트랜잭션
        private int _ExecNonQuery_NoTran(string proc, Hashtable ht, string conn)
        {
            SqlConnection dbConn = null;
            SqlCommand dbComm = null;
            int rtCnt;
            try
            {
                dbConn = this._dbConn(dbConn, conn);
                dbComm = new SqlCommand();
                dbComm.Connection = dbConn;
                dbComm.CommandTimeout = 3000; //5분
                dbComm.CommandType = CommandType.StoredProcedure;
                dbComm.CommandText = proc;

                //파라메터 등록
                if (ht.Count > 0)
                    this._AddParam(ref dbComm, ref ht);

                //실행
                dbConn.Open();
                               

                rtCnt = dbComm.ExecuteNonQuery();

                dbConn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dbConn.State == ConnectionState.Open || dbConn.State == ConnectionState.Connecting)
                    dbConn.Close();
            }

            return rtCnt;
        }
        #endregion

        #region 단일값반환메서드
        private object _ExecScalarQuery(string proc, Hashtable ht, string conn)
        {
            SqlConnection dbConn = null;
            SqlCommand dbComm = null;
            object data = null;
            SqlTransaction trans = null;
            try
            {
                dbConn = this._dbConn(dbConn, conn);
                dbComm = new SqlCommand();
                dbComm.Connection = dbConn;
                dbComm.CommandTimeout = 3000; //5분
                dbComm.CommandType = CommandType.StoredProcedure;
                dbComm.CommandText = proc;

                //파라메터 등록
                if (ht.Count > 0)
                    this._AddParam(ref dbComm, ref ht);

                //실행
                dbConn.Open();
                
                //트랜잭션 시작..
                trans = dbConn.BeginTransaction();
                dbComm.Transaction = trans;

                data = dbComm.ExecuteScalar();

                //커밋..
                trans.Commit();
                dbConn.Close();
            }
            catch (Exception ex)
            {
                //롤백..
                trans.Rollback();
                throw ex;
            }
            finally
            {
                if (dbConn.State == ConnectionState.Open || dbConn.State == ConnectionState.Connecting)
                    dbConn.Close();
            }

            return data;
        }
        #endregion

        #region DataSet반환메서드
        private DataSet _ExecDataSetQuery(string proc, Hashtable ht, string conn)
        {
            SqlConnection dbConn = null;
            SqlCommand dbComm = null;
            SqlDataAdapter adap = null;
            DataSet ds = new DataSet();
            try
            {
                dbConn = this._dbConn(dbConn, conn);
                dbComm = new SqlCommand();
                dbComm.Connection = dbConn;
                dbComm.CommandTimeout = 3000; //5분
                dbComm.CommandType = CommandType.StoredProcedure;
                dbComm.CommandText = proc;

                //파라메터 등록
                if (ht.Count > 0)
                    this._AddParam(ref dbComm, ref ht);

                //실행
                adap = new SqlDataAdapter(dbComm);
                adap.Fill(ds);
            }
            catch (Exception ex)
            {
                //오류발생시 DataSet 의 모든 리소스 제거
                ds.Dispose();
                throw ex;
            }
            finally
            {
                if (dbConn.State == ConnectionState.Open || dbConn.State == ConnectionState.Connecting)
                    dbConn.Close();
            }
            //리턴
            return ds;
        }

        #endregion

        #region DataTable반환메서드
        private DataTable _ExecDataTableQuery(string proc, Hashtable ht, string conn)
        {
            SqlConnection dbConn = null;
            SqlCommand dbComm = null;
            SqlDataAdapter adap = null;
            DataTable dt = new DataTable();
            try
            {
                dbConn = this._dbConn(dbConn, conn);
                dbComm = new SqlCommand();
                dbComm.Connection = dbConn;
                dbComm.CommandTimeout = 3000; //5분
                dbComm.CommandType = CommandType.StoredProcedure;
                dbComm.CommandText = proc;

                //파라메터 등록
                if (ht.Count > 0)
                    this._AddParam(ref dbComm, ref ht);

                //실행
                adap = new SqlDataAdapter(dbComm);
                adap.Fill(dt);
            }
            catch (Exception ex)
            {
                //오류발생시 DataSet 의 모든 리소스 제거
                dt.Dispose();
                throw ex;
            }
            finally
            {
                if (dbConn.State == ConnectionState.Open || dbConn.State == ConnectionState.Connecting)
                    dbConn.Close();
            }
            //리턴
            return dt;
        }

        #endregion

        
        #region DataTable반환메서드
        private DataTable _ExecDataTableQuery(string proc, Hashtable ht, ref Hashtable htOutput, string conn)
        {
            SqlConnection dbConn = null;
            SqlCommand dbComm = null;
            SqlDataAdapter adap = null;
            DataTable dt = new DataTable();
            try
            {
                dbConn = this._dbConn(dbConn, conn);
                dbComm = new SqlCommand();
                dbComm.Connection = dbConn;
                dbComm.CommandTimeout = 3000; //5분
                dbComm.CommandType = CommandType.StoredProcedure;
                dbComm.CommandText = proc;

                //파라메터 등록
                if (ht.Count > 0)
                    this._AddParam(ref dbComm, ref ht);

                //Output파라메터 등록
                if (ht.Count > 0)
                    this._AddOutputParam(ref dbComm, ref htOutput);

                //실행
                adap = new SqlDataAdapter(dbComm);
                adap.Fill(dt);
                                
                //Output파라메터 반환
                Hashtable htTemp = new Hashtable();
                IDictionaryEnumerator ieOutput = htOutput.GetEnumerator();
                while (ieOutput.MoveNext())
                {
                    htTemp.Add(ieOutput.Key.ToString(), dbComm.Parameters[ieOutput.Key.ToString()].Value);
                    //htOutput[ieOutput.Key] = dbComm.Parameters[ieOutput.Key.ToString()].Value;    //열거자변경오류 남.
                }
                htOutput = htTemp;
            }
            catch (Exception ex)
            {
                //오류발생시 DataSet 의 모든 리소스 제거
                dt.Dispose();
                throw ex;
            }
            finally
            {
                if (dbConn.State == ConnectionState.Open || dbConn.State == ConnectionState.Connecting)
                    dbConn.Close();
            }
            //리턴
            return dt;
        }

        #endregion

        #region DataTable반환메서드 - Reader 사용
        private DataTable _ExecDataTableQuery_Reader(string proc, Hashtable ht, string conn)
        {
            SqlConnection dbConn = null;
            SqlCommand dbComm = null;
            SqlDataReader sdr = null;
            DataTable dt = new DataTable();
            try
            {
                dbConn = this._dbConn(dbConn, conn);
                dbComm = new SqlCommand();
                dbComm.Connection = dbConn;
                dbComm.CommandTimeout = 3000; //5분
                dbComm.CommandType = CommandType.StoredProcedure;
                dbComm.CommandText = proc;

                //파라메터 등록
                if (ht.Count > 0)
                    this._AddParam(ref dbComm, ref ht);

                //실행
                dbConn.Open();
                sdr = dbComm.ExecuteReader();
                dt.Load(sdr);
            }
            catch (Exception ex)
            {
                //오류발생시 DataSet 의 모든 리소스 제거
                dt.Dispose();
                throw ex;
            }
            finally
            {
                if (dbConn.State == ConnectionState.Open || dbConn.State == ConnectionState.Connecting)
                    dbConn.Close();
            }
            //리턴
            return dt;
        }

        #endregion

        #region 파라메터등록메서드

        private void _AddParam(ref SqlCommand comm, ref Hashtable ht)
        {
            //입력된 값이 4000자 초과할때에는 TEXT나, NTEXT타입으로 정의된 것이므로
            //TEXT타입으로 지정하여서 파라메터를 등록한다.
            IDictionaryEnumerator ie = ht.GetEnumerator();
            while (ie.MoveNext())
            {
                if (ie.Value.ToString().Length <= 4000)
                    comm.Parameters.Add(new SqlParameter(ie.Key.ToString(), ie.Value));
                else
                {
                    comm.Parameters.Add(ie.Key.ToString(), SqlDbType.Text);
                    comm.Parameters[ie.Key.ToString()].Value = ie.Value.ToString();
                }
            }
        }
        #endregion

        #region Output 파라메터등록메서드

        private void _AddOutputParam(ref SqlCommand comm, ref Hashtable htOutput)
        {
            IDictionaryEnumerator ie = htOutput.GetEnumerator();
            while (ie.MoveNext())
            {                
                comm.Parameters.Add(new SqlParameter(ie.Key.ToString(), ie.Value));                
                comm.Parameters[ie.Key.ToString()].Direction = ParameterDirection.Output;                
            }                       
        }
        #endregion

        #region 연결자반환메서드

        private SqlConnection _dbConn(SqlConnection dbConn, string conn)
        {
            switch (conn)
            {   
                default:
                    if (Login.G_TARGET_DB == "TEST")
                    {
                        dbConn = new SqlConnection(base.getTestConnString);
                    }
                    else if (Login.G_TARGET_DB == "ACTIVE")
                    {
                        dbConn = new SqlConnection(base.DefaultConnSting);
                    }
                    else
                    {
                        dbConn = null;
                    }
                    break;
            }

            return dbConn;
        }

        #endregion

        #region 싱글행 그룹등록메서드
        private void _ExecNonQueryTran_SingleRowGroup(Hashtable[] sGroup, string conn)
        {
            SqlConnection dbConn = null;
            SqlCommand dbComm = null;
            //Hashtable을 받아서 처리하는 객체..
            IDictionaryEnumerator ie = null;

            SqlTransaction trans = null;
            try
            {
                dbConn = this._dbConn(dbConn, conn);
                dbComm = new SqlCommand();
                dbComm.Connection = dbConn;
                dbComm.CommandTimeout = 3000; //5분
                dbComm.CommandType = CommandType.StoredProcedure;

                //DB OPEN..
                dbConn.Open();

                //
                //트랜잭션 시작..
                //
                trans = dbConn.BeginTransaction();
                dbComm.Transaction = trans;

                //
                //단일레코드등록..
                //
                Hashtable sht = new Hashtable();
                for (int s = 0; s < sGroup.Length; s++)
                {
                    if (sGroup[s] == null || sGroup[s].ToString() == "")
                        continue;

                    sht = sGroup[s];
                    ie = sht.GetEnumerator();
                    Hashtable ht = null;
                    while (ie.MoveNext())
                    {
                        dbComm.CommandText = ie.Key.ToString();//프로시저명..
                        ht = (Hashtable)ie.Value;
                        if (ht != null)//null이 아니면 등록프로세스 시행..
                        {
                            //파라메터 클리어..
                            dbComm.Parameters.Clear();
                            if (ht.Count > 0)
                                this._AddParam(ref dbComm, ref ht);
                            //실행..
                            dbComm.ExecuteNonQuery();
                        }
                    }
                }

                //커밋..
                trans.Commit();

                dbConn.Close();
            }
            catch (Exception exp)
            {
                //롤백..
                trans.Rollback();
                throw exp;
            }
            finally
            {
                if (dbConn.State == ConnectionState.Open || dbConn.State == ConnectionState.Connecting)
                    dbConn.Close();
            }
        }
        #endregion

        #region 멀티행그룹등록메서드
        private void _ExecNonQueryTran_MultiRowsGroup(Hashtable[] mGroup, string conn)
        {
            SqlConnection dbConn = null;
            SqlCommand dbComm = null;
            //Hashtable을 받아서 처리하는 객체..
            IDictionaryEnumerator ie = null;
            int i = 0;

            SqlTransaction trans = null;
            try
            {
                dbConn = this._dbConn(dbConn, conn);
                dbComm = new SqlCommand();
                dbComm.Connection = dbConn;
                dbComm.CommandTimeout = 3000; //5분
                dbComm.CommandType = CommandType.StoredProcedure;

                //DB OPEN..
                dbConn.Open();

                //
                //트랜잭션 시작..
                //
                trans = dbConn.BeginTransaction();
                dbComm.Transaction = trans;
                //
                //다중레코드 등록..
                //
                Hashtable mht = new Hashtable();
                for (int m = 0; m < mGroup.Length; m++)
                {
                    if (mGroup[m] == null || mGroup[m].ToString() == "")
                        continue;

                    mht = mGroup[m];
                    ie = mht.GetEnumerator();
                    Hashtable[] valHt = null;
                    while (ie.MoveNext())
                    {
                        dbComm.CommandText = ie.Key.ToString();//프로시저명..
                        valHt = (Hashtable[])ie.Value;
                        if (valHt != null)
                        {
                            for (i = 0; i < valHt.Length; i++)
                            {
                                if (valHt[i] != null)
                                {
                                    //파라메터 클리어..
                                    dbComm.Parameters.Clear();
                                    //파라메터등록..
                                    if (valHt[i].Count > 0)
                                        this._AddParam(ref dbComm, ref valHt[i]);
                                    //실행..				
                                    dbComm.ExecuteNonQuery();
                                }
                            }
                        }

                    }
                }
                //커밋..
                trans.Commit();

                dbConn.Close();
            }
            catch (Exception exp)
            {
                //롤백..
                trans.Rollback();
                throw exp;
            }
            finally
            {
                if (dbConn.State == ConnectionState.Open || dbConn.State == ConnectionState.Connecting)
                    dbConn.Close();
            }
        }
        #endregion

        #region 복합행그룹등록메서드
        private void _ExecNonQueryTran_Complex(Hashtable[] sGroup, Hashtable[] mGroup, string conn)
        {
            SqlConnection dbConn = null;
            SqlCommand dbComm = null;
            //Hashtable을 받아서 처리하는 객체..
            IDictionaryEnumerator ie = null;
            int i = 0;

            SqlTransaction trans = null;
            try
            {
                dbConn = this._dbConn(dbConn, conn);
                dbComm = new SqlCommand();
                dbComm.Connection = dbConn;
                dbComm.CommandTimeout = 3000; //5분
                dbComm.CommandType = CommandType.StoredProcedure;

                //DB OPEN..
                dbConn.Open();

                //
                //트랜잭션 시작..
                //
                trans = dbConn.BeginTransaction();
                dbComm.Transaction = trans;

                //
                //단일레코드등록..
                //
                Hashtable sht = new Hashtable();
                for (int s = 0; s < sGroup.Length; s++)
                {
                    if (sGroup[s] == null)
                        continue;

                    sht = sGroup[s];
                    ie = sht.GetEnumerator();
                    Hashtable ht = null;
                    while (ie.MoveNext())
                    {
                        dbComm.CommandText = ie.Key.ToString();//프로시저명..
                        ht = (Hashtable)ie.Value;
                        if (ht != null)//null이 아니면 등록프로세스 시행..
                        {
                            //파라메터 클리어..
                            dbComm.Parameters.Clear();
                            if (ht.Count > 0)
                                this._AddParam(ref dbComm, ref ht);
                            //실행..
                            dbComm.ExecuteNonQuery();
                        }
                    }
                }

                //
                //다중레코드  등록..
                //
                Hashtable mht = new Hashtable();
                for (int m = 0; m < mGroup.Length; m++)
                {
                    if (mGroup[m] == null)
                        continue;

                    mht = mGroup[m];
                    ie = mht.GetEnumerator();
                    Hashtable[] valHt = null;
                    while (ie.MoveNext())
                    {
                        dbComm.CommandText = ie.Key.ToString();//프로시저명..
                        valHt = (Hashtable[])ie.Value;
                        if (valHt != null)
                        {
                            for (i = 0; i < valHt.Length; i++)
                            {
                                if (valHt[i] != null)
                                {
                                    //파라메터 클리어..
                                    dbComm.Parameters.Clear();
                                    //파라메터등록..
                                    if (valHt[i].Count > 0)
                                        this._AddParam(ref dbComm, ref valHt[i]);
                                    //실행..				
                                    dbComm.ExecuteNonQuery();
                                }
                            }
                        }

                    }
                }
                //커밋..
                trans.Commit();

                dbConn.Close();
            }
            catch (Exception exp)
            {
                //롤백..
                trans.Rollback();
                throw exp;
            }
            finally
            {
                if (dbConn.State == ConnectionState.Open || dbConn.State == ConnectionState.Connecting)
                    dbConn.Close();
            }
        }
        #endregion

        #endregion
    }
}
