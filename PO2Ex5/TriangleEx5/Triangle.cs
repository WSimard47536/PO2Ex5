using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleEx5
{
    /// <summary>
    /// Classe gérant des triangles de tout type avec trois côtés arbitraires
    /// </summary>
    public class Triangle
    {
        private int cote1;
        private int cote2;
        private int cote3;
        /// <summary>
        /// Contructeur qui prend les trois côtés en paramètre.
        /// </summary>
        /// <param name="cote1">Premier côté</param>
        /// <param name="cote2">Seconde côté</param>
        /// <param name="cote3">Troisième côté</param>
        public Triangle(int cote1, int cote2, int cote3)
        {
            this.cote1 = cote1;
            this.cote2 = cote2;
            this.cote3 = cote3;
        }

        /// <summary>
        /// Calcule le périmètre en fonction des valeurs contenues dans le triangle
        /// </summary>
        /// <returns>
        /// Le périmètre calculé (int)
        /// </returns>
        public int GetParameter()
        {
            return cote1 + cote2 + cote3;
        }
        /// <summary>
        /// Construit un nouveau triangle à partir de celui-ci et d'un paramètre multiplicateur
        /// </summary>
        /// <param name="scale">Le multiplicateur</param>
        /// <returns>
        /// Le nouveau Triangle
        /// </returns>
        public Triangle Scale(int scale)
        {
            return new Triangle(cote1 * scale, cote2 * scale, cote3 * scale);
        }
    }
}
