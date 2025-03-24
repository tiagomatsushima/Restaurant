using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante
{
    public static class Logger
    {
        private static readonly string LogFilePath = "C:\\RestaurantLog\\log.txt";

        public static void Log(string mensagem)
        {
            using (StreamWriter writer = new StreamWriter(LogFilePath,true))
            {
                writer.WriteLine($"{DateTime.Now}: {mensagem}");
            }
        }
    }
}