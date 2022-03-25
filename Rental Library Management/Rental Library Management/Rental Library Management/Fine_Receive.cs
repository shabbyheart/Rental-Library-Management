using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_Library_Management
{
    class Fine_Receive
    {
        int studentId;
        double amount;

        public int StudentId { get => studentId; set => studentId = value; }
        public double Amount { get => amount; set => amount = value; }
    }
}
