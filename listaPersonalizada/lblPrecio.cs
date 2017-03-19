using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaPersonalizada
{
    /// <summary>
    /// Genera una label personalizada para establecer los precios
    /// </summary>
    public partial class lblPrecio : UserControl
    {
        public lblPrecio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Establece:
        /// <para>    · El precio del item</para>
        /// <para>    · La cantidad de monedas del usuario</para>
        /// <para>    · El precio total de la compra</para>
        /// </summary>
        /// <param name="precio">String precio: Precio de: PrecioItem/MonedasUser/TotalCompra</param>
        public void setPrecio (string precio)
        {
            lblTxtPrecio.Text = precio;
        }

        /// <summary>
        /// Recupera el valor de:
        /// <para>    · El precio del item</para>
        /// <para>    · La cantidad de monedas del usuario</para>
        /// <para>    · El precio total de la compra</para>
        /// </summary>
        /// <returns>String precio: Valor de: PrecioItem/MonedasUser/TotalCompra</returns>
        public string getPrecio()
        {
            return lblTxtPrecio.Text;
        }
    }
}
