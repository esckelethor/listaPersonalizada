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
    /// Genera un nuevo control con las propiedades minimas del item a comprar
    /// </summary>
    public partial class itemToBuy : UserControl
    {
        public itemToBuy()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Establece la imagen del item a comprar
        /// </summary>
        /// <param name="imagen">Iamge imagen: Imagen del item</param>
        public void setImagenItem(Image imagen)
        {
            imgItem.Image = imagen;
        }

        /// <summary>
        /// Establece el precio del item a comprar
        /// </summary>
        /// <param name="precio">String precio: Precio del item</param>
        public void setPrecioItem(string precio)
        {
            lblPrecio.Text = precio;
        }

        /// <summary>
        /// Recupera el precio del item a comprar
        /// </summary>
        /// <returns>String precio: Precio del item</returns>
        public String getPrecioItem()
        {
            return lblPrecio.Text;
        }

        /// <summary>
        /// Establece el color del precio en funcion del grado del item
        /// </summary>
        /// <param name="color">Color color: Color del texto</param>
        public void setGradeColor(Color color)
        {
            lblPrecio.ForeColor = color;
        }
    }
}
