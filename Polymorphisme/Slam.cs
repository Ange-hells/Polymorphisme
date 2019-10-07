using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme
{
	public class Slam : Eleve
	{
		private string laCompetence;

		public Slam(string unNom, string unPrenom, string unNumero, string uneCompetence)
			:base(unNom,unPrenom,unNumero)
        {
			laCompetence = uneCompetence;
		}

		public string Competence
		{
			get { return laCompetence; }
			set
			{ laCompetence = value; }
		}

		public override string EditerOption()
		{
			return "Slam" + laCompetence;
		}
	}
}