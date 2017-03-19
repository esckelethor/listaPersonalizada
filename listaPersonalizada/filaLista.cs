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
    /// Genera un nuevo control con las propiedades de un item
    /// </summary>
    public partial class filaLista : UserControl
    {
        
        public filaLista()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Establece la imagen del item
        /// </summary>
        /// <param name="imagen">Image imagen: Imagen del item</param>
        public void setImagenItem(Image imagen)
        {
            imgItem.Image = imagen;
        }

        /// <summary>
        /// Establece el nombre del item
        /// </summary>
        /// <param name="nombre">String nombre: Nombre del item</param>
        public void setNombreItem(string nombre)
        {
            lblNombreItem.Text = nombre;
        }

        /// <summary>
        /// Recupera el nombre del item
        /// </summary>
        /// <returns>String nombre: Nombre del item</returns>
        public string getNombreItem()
        {
            return lblNombreItem.Text;
        }

        /// <summary>
        /// Establece el precio del item
        /// </summary>
        /// <param name="precio">String precio: Precio del item</param>
        public void setPrecioItem (string precio)
        {
            lblPrecio.Text = precio;
        }

        /// <summary>
        /// Recupera el nombre del item
        /// </summary>
        /// <returns>String precio: Precio del item</returns>
        public String getPrecioItem()
        {
            return lblPrecio.Text;
        }


        /// <summary>
        /// Establece el color del nombre del item en funcion del grado
        /// <para>    Color grade: Variable establecida en la clase Item</para>
        /// </summary>
        /// <param name="color">Color color: Color del texto</param>
        public void setGradeColor(Color color)
        {
            lblNombreItem.ForeColor = color;
        }

        /// <summary>
        /// Metodo para implementar drag&drop
        /// <para>Guarda los valores de:</para>
        /// <para>    Bitmap imagen: Imagen del item</para>
        /// <para>    String nombre: Nombre del item</para>
        /// <para>    String foreColor: Color del nombre del texto, asociado al grado del item</para>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void filaLista_MouseDown(object sender, MouseEventArgs e)
        {
            List<object> data = new List<object>();
            data.Add(imgItem.Image);
            data.Add(lblPrecio.Text);
            data.Add(lblNombreItem.ForeColor.ToKnownColor().ToString());

            this.DoDragDrop(data, DragDropEffects.Copy);
        }
    }
}
