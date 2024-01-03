using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication2
{
    public class SqlHelper
    {

        public DataSet getDataSet()
        {
            DataSet ds = new DataSet();

            // 임의 테이블을 만들고 입력한다.
            DataTable dt = new DataTable("TB_SAWON");

            dt.Columns.Add(new DataColumn("SA_NO", typeof(string)));
            dt.Columns.Add(new DataColumn("SA_CD", typeof(string)));
            dt.Columns.Add(new DataColumn("SA_NM", typeof(string)));

            ds.Tables.Add(dt);

            string[] sa_no = { "1", "2", "3", "4", "5", "6" };
            string[] sa_cd = { "bj", "cj", "gj", "dr", "jy", "sw"};
            string[] sa_nm = { "길동", "밀동", "산동", "경동", "전동", "타동"};

                

            DataRow row = null;
            for (int i = 0; i < 6; i++)
            {
                row = ds.Tables["TB_SAWON"].NewRow();
                row["SA_NO"] = sa_no[i];
                row["SA_CD"] = sa_cd[i];
                row["SA_NM"] = sa_nm[i];
                ds.Tables["TB_SAWON"].Rows.Add(row);
            }


            return ds;
            
        }

        public DataSet getDataSet(string Key)
        {
            DataSet ds = getDataSet();

            if (!string.IsNullOrEmpty(Key))
            {
                var SAWON_Table = (from data in ds.Tables["TB_SAWON"].AsEnumerable()
                     where data.Field<string>("SA_CD") == Key
                     select data).CopyToDataTable();

                ds.Tables.Clear();

                DataTable dt = new DataTable();

                dt = (DataTable)SAWON_Table;
                dt.TableName = "TB_SAWON";

                ds.Tables.Add(dt);
            }

            return ds;
        }



    }
}
