using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3_1
{
    public class Transport
    {
        public virtual string Tipe { get { return "Транспорт"; } }         // Тип транспорта
        public virtual double Revenue { get; set; }     // Выручка
    }
}
