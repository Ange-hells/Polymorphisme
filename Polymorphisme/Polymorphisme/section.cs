using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphisme
{
	public class section
	{

		private List<Eleve> lesEleves;
		
		public void ajouterEleves(Eleve unEleve)
		{
			lesEleves.Add(unEleve);
		}

		public List<Eleve> getlesEleves()
		{
			return lesEleves;
		}

		public int NbEleves()
		{
			return lesEleves.Count();
		}

		public section()
		{
			lesEleves = new List<Eleve>();

		}

		public void Trier()
		{

			for (int i = 0; i <= lesEleves.Count() - 1; i++)
			{
				Eleve temp;
				for (int j = 0; j < lesEleves.Count() - 1; j++)
				{
					if (lesEleves[j].Comparer(lesEleves[j + 1]) > 0)
					{
						temp = lesEleves[j];
						lesEleves[j] = lesEleves[j + 1];
						lesEleves[j + 1] = temp;
					}//end if
				}//end for
			}//end for
		}//end trier
	}//end class
}