using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace MCS
{

    public class SQLOperations
    {

        public DataTable GetDataFromDatabase(string Query)
        {
            var DT = new DataTable();
            try
            {
                MCS.Class1.CONNIC();
                var DA = new SqlDataAdapter(Query, MCS.Module1.cn);
                var DS = new DataSet();

                DA.Fill(DS, "MyTable");

                if (DS.Tables[0].Rows.Count > 0)
                {
                    DT = DS.Tables[0];
                }
                else
                {
                    DT = null;
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox($"حدث خطأ أثناء عملية جلب البيانات {ex.Message}", MsgBoxStyle.Information);
            }

            return DT;
        }

        public decimal GetValueFromDB(string Aggregate, string FieldName, string TableName, string Extra)
        {
            decimal RV = 0m;
            try
            {
                MCS.Class1.CONNIC();
                var DT = new DataTable();
                var DA = new SqlDataAdapter($"Select {Aggregate}({FieldName}) from {TableName} {Extra}", MCS.Module1.cn);
                var DS = new DataSet();

                DA.Fill(DS, "MyTable");
                DT = DS.Tables[0];

                if (DT.Rows.Count > 0)
                {
                    RV = Conversions.ToDecimal(DT.Rows[0][0]);
                }
                else
                {
                    RV = 0m;
                }
            }
            catch (Exception ex)
            {
                // MsgBox($"حدث خطأ أثناء عملية جلب البيانات: {ex.Message}", MsgBoxStyle.Information)
            }
            return RV;
        }
    }
}