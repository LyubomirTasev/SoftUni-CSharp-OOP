using MillitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MillitaryElite.Implementation
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            Privates = new List<IPrivate>();
        }

        public List<IPrivate> Privates { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            string baseInfo =  base.ToString(); // преизползваме ToString-a на базовия клас

            sb.AppendLine(baseInfo);
            sb.AppendLine("Privates:");

            foreach (var item in Privates)
            {
                sb.AppendLine($"  {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
