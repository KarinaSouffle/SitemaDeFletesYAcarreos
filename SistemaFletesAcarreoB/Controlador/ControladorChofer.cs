﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SistemaFletesAcarreoB.Controlador;
using SistemaFletesAcarreoB.Modelo;
using System.Windows.Forms;

namespace SistemaFletesAcarreoB.Controlador
{
    public class ControladorChofer
    {
        public static void CrearChofer(CHOFER nuevoChofer)
        {
            try
            {
                int control = 0;
                if (nuevoChofer.lICENCIA_C == string.Empty ||
                    nuevoChofer.N_Chofer == string.Empty ||
                    nuevoChofer.ApellidoP_C == string.Empty ||
                    nuevoChofer.ApellidoM_C == string.Empty ||
                    nuevoChofer.Sexo == string.Empty ||
                    nuevoChofer.Edad == string.Empty ||
                    nuevoChofer.Telefono == string.Empty ||
                    nuevoChofer.Correo == string.Empty ||
                    nuevoChofer.F_Nac == DateTime.MinValue ||
                    nuevoChofer.Direccion == string.Empty ||
                    nuevoChofer.Disponible == string.Empty)
                {
                    MessageBox.Show("Hay campos vacios.", "Error", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        int edad = Int32.Parse(nuevoChofer.Edad.ToString());
                        //int telefono = Int32.Parse(nuevoChofer.Telefono.ToString());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hay datos con el formato incorrecto.", "Error", MessageBoxButtons.OK);
                        control = 1;
                    }
                    if (control != 1)
                    {
                        ModeloChofer.crearChofer(nuevoChofer);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hubo un error al almacenar los datos", "Error", MessageBoxButtons.OK);
            }
        }
        //Singleton.
        public sealed class Singleton
        {
            Singleton()
            {
                CHOFER nuevoChofer;
            }
            private static readonly object padlock = new object();
            private static Singleton nuevoChofer = null;
            public static Singleton proove
            {
                get
                {
                    lock (padlock)
                    {
                        if (nuevoChofer == null)
                        {
                            nuevoChofer = new Singleton();
                        }
                        return nuevoChofer;
                    }
                }
            }
        }
        public static List<CHOFER> BuscarChoferesPorCriterio(String criterio)
        {
            try
            {
                var resultado = ModeloChofer.buscarChoferPorCriterio(criterio);
                return resultado;
            }
            catch (Exception ex)
            {

                throw new Exception("Error " + ex.Message);
            }
        }
        public static List<CHOFER> BuscarChoferesPorDisponibilidad(String criterio)
        {
            try
            {
                var resultado = ModeloChofer.buscarChoferPorDisponibilidad(criterio);
                return resultado;
            }
            catch (Exception ex)
            {

                throw new Exception("Error " + ex.Message);
            }
        }

        public static void EliminarChofer(int idChofer)
        {
            try
            {
                if (idChofer < 0)
                {
                    throw new Exception("Codigo no puede ser menor 0.");
                }
                else
                {
                    ModeloChofer.eliminarChofer(idChofer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar. ", "Error", MessageBoxButtons.OK);
            }
        }

        public static void ModificarChofer(CHOFER ChoferModificar)
        {
            try
            {
                if (ChoferModificar.Id_Chofer < 0)
                {
                    throw new Exception("Valor de Codigo nulo");
                }
                ModeloChofer.modificarChofer(ChoferModificar);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Revisa los datos introducidos", "Error", MessageBoxButtons.OK);
            }
        }

        public static CHOFER BuscarChoferPorId(int idChofer)
        {
            try
            {
                if (idChofer < 0)
                {
                    throw new Exception("No existe Codigo menor que 0.");
                }
                else
                {
                    var resultado = ModeloChofer.buscarChoferPorId(idChofer);
                    return resultado;
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error " + ex.Message);
            }
        }
    }
}
