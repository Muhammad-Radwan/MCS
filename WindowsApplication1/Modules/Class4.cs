using System.Data;

namespace MCS
{
    public class Class4
    {
        public static void CONNIC()
        {
            if (MCS.Module1.cn.State == ConnectionState.Closed)
            {
                MCS.Module1.cn.Open();
            }
            else
            {
                // CALL CLASS4.CONNIC()
            }
        }
    }
}