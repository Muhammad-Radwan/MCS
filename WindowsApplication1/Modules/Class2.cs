using Microsoft.VisualBasic.CompilerServices;

namespace MCS
{
    public class Class2
    {
        public static void BUTTON(object B)
        {
            MCS.Class1.CONNIC();
            string ser = "select * from KESEM where IDK=xs";
            var cmser = new System.Data.SqlClient.SqlCommand(ser, MCS.Module1.cn);
            cmser.Parameters.AddWithValue("xs", B);
            var rdser = cmser.ExecuteReader();
            if (rdser.Read() == true)
            {
                MCS.Module1.KESEM = Conversions.ToString(rdser["KESEM"]);
            }
            rdser.Close();
            MCS.Class1.CONNIC();
        }
    }
}