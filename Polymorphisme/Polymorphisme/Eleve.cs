using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme
{
	public abstract class Eleve : ICompare
	{
		private string leNom;
		private string lePrenom;
		private string leNumero;

		public Eleve(string unNom, string unPrenom, string unNumero)
		{
			leNom = unNom;
			lePrenom = unPrenom;
			leNumero = unNumero;
		}

		public string Nom
		{
			get { return leNom; }
			set
			{ leNom = value; }
		}

		public string Prenom
		{
			get { return lePrenom; }
			set
			{ lePrenom = value; }
		}

		public string Numero
		{
			get { return leNumero; }
			set
			{ leNumero = value; }
		}

		public abstract string EditerOption();

		public int Comparer(object obj)
		{ 
		Eleve lEleve = (Eleve)obj;

			if (this.leNom != lEleve.leNom)
			{
				return this.leNom.CompareTo(lEleve.leNom);
			}
			else
			{
				return this.lePrenom.CompareTo(lEleve.lePrenom);
			}
		}
	}
}