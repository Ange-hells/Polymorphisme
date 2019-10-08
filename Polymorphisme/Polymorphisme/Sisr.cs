using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme
{
	public class Sisr : Eleve
	{
		private string laCertification;

		public string Certification
		{
			get { return laCertification; }
			set
			{ laCertification = value; }
		}

		public override string EditerOption()
		{
			return "Sisr" + laCertification;
		}

		public Sisr(string unNom, string unPrenom, string unNumero, string uneCertification)
			:base(unNom,unPrenom,unNumero)
        {
			laCertification = uneCertification;
		}
	}

}