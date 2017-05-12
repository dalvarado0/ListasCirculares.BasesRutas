using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasesRutas
{
    class Tour
    {
        Base inicio, ultimo;

        public Tour()
        {

        }

        /// <summary>
        /// Agregar un nuevo elemento
        /// </summary>
        /// <param name="nuevo">Objeto de tipo Base</param>
        public void agregar(Base nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
                inicio.next = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.next = nuevo;
                nuevo.next = inicio;
                ultimo = nuevo;
            }
        }

        /// <summary>
        /// Agrega el producto al inicio de la lista.
        /// </summary>
        /// <param name="nuevo">Objeto producto que se va agregar a la lista.</param>
        public void agregarInicio(Base nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
                inicio.next = nuevo;
                ultimo = nuevo;
            }
            else
            {
                nuevo.next = inicio;
                inicio = nuevo;
                ultimo.next = inicio;
            }

        }

        public void agregarFinal(Base nuevo)
        {
            nuevo.next = inicio;
            ultimo = nuevo;
            ultimo.next = nuevo;
        }

        public void eliminarUltimo()
        {
            Base temp = inicio;
           
            if (temp != null)
            {
                if (temp.next == inicio)
                {
                    inicio = null;
                }
                else
                {
                    while (temp.next != inicio)
                    {
                        if (temp.next == ultimo)
                        {
                            temp.next = inicio;
                            ultimo = temp;
                            break;
                        }
                        temp = temp.next;
                    }
              
                }
            }
        }

        public void eliminarPrimero()
        {
            if(inicio == ultimo)
            {
                inicio = null;
                ultimo = null;
            }
            if(inicio != null)
            {
                ultimo.next = inicio.next;
                inicio = inicio.next;
            }     
        }

        public void eliminar(string nombre)
        {
            Base temp = inicio;
            while (temp.next != inicio)
            {
                if (temp.name == nombre)
                {
                    inicio = temp.next;
                    temp = inicio;
                }
                else
                {
                    if (temp.next.name == nombre)
                    {
                        temp.next = temp.next.next;
                        //if(temp.next == ultimo)
                        //   ultimo = temp.next.next;
                        break;
                    }
                    temp = temp.next;
                }
            }
        }

        public Base buscar(string nombre)
        {
            Base item = null, temp = inicio;
            while (temp.next != inicio)
            {
                if (temp.name == nombre)
                {
                    return temp;
                }
                if (temp.next.name == nombre)
                    item = temp.next;
                temp = temp.next;
            }
            return item;
        }

        public string reporte()
        {
            string datos = "";
            Base temp = inicio;
            if(temp != null)
            {
                while (temp.next != inicio)
                {
                    datos += temp.ToString() + Environment.NewLine;
                    temp = temp.next;
                }
                datos += ultimo.ToString();
                return datos;
            }
            return "No info";
        }

        public void insertar(Base nueva, string nombre)
        {
            Base temp = inicio;
            if(temp.next != inicio)
            {
                while(temp.next != inicio)
                {
                    if(temp.name == nombre)
                    {
                        nueva.next = temp.next;
                        temp.next = nueva;
                        break;
                    }
                    temp = temp.next;
                }
            }
        }
    }
}
