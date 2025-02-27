﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaFletesAcarreoB.Controlador;
using SistemaFletesAcarreoB.Modelo;

namespace SistemaFletesAcarreoB.Vista
{
    public partial class RegistroUsuarioLogin : Form
    {
        public RegistroUsuarioLogin()
        {
            InitializeComponent();
        }

        private void RegistroUsuarioLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sISTEMAFLETESACARREOSDataSet.USUARIOS' Puede moverla o quitarla según sea necesario.
            this.uSUARIOSTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.USUARIOS);

        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            Validar validar = new Validar();
            int xd = Int32.Parse(dgv_Usuarios.Rows.Count.ToString());
            string seleccionada = "";
            String cb_nivel = "";
            for (int i = 0; i < xd - 1; i++)
            {
                string compara = dgv_Usuarios.Rows[i].Cells[1].Value.ToString();
                if (compara == txt_Nombre.Text.ToString())
                {
                    seleccionada = compara;
                    Console.WriteLine("Seleccionada " + seleccionada);
                }
            }
            if (seleccionada == string.Empty)
            {
                if (txt_Contraseña.Text == txt_CContraseña.Text)
                {
                    if (validar.ValidatePassword(txt_Contraseña.Text) == true && validar.ValidarNombre(txt_Nombre.Text, "nombre de usuario") == true)
                    {
                        try
                        {
                            cb_nivel = "2";
                            var nuevoUsuario = new USUARIOS();
                            nuevoUsuario.Nombre = txt_Nombre.Text;
                            nuevoUsuario.Contra = txt_Contraseña.Text;
                            nuevoUsuario.Nivel = cb_nivel;
                            nuevoUsuario.EnUso = "2";
                            ControladorUsuario.crearUsuario(nuevoUsuario);

                            int cantidaddatos = Int32.Parse(dgv_Usuarios.Rows.Count.ToString());
                            this.uSUARIOSTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.USUARIOS);
                            int cantidadnuevosautos = Int32.Parse(dgv_Usuarios.Rows.Count.ToString());
                            if (cantidadnuevosautos == (cantidaddatos + 1))
                            {
                                var respuesta = MessageBox.Show(
                                "Usuario guardado correctamente, ¿Desea agregar otro?",
                                "Mensaje del sistema",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);
                                if (respuesta == DialogResult.Yes)
                                {
                                    txt_Nombre.Text = string.Empty;
                                    txt_Contraseña.Text = string.Empty;
                                    txt_CContraseña.Text = string.Empty;
                                    this.uSUARIOSTableAdapter.Fill(this.sISTEMAFLETESACARREOSDataSet.USUARIOS);
                                }
                                else
                                {
                                    Dispose();
                                }
                            }

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Revisa los datos introducidos", "Error", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Ya existe un usuario registrado con el mismo nombre.", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
