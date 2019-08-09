using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Preguntas;

namespace Examen
{
    public partial class Preguntas : Form
    {
        int resultado = 0;
        int seleccion = 0;

        public Preguntas()
        {
            InitializeComponent();
        }
        private void Preguntas_Load(object sender, EventArgs e)
        {
           Limpiar();
           pregunta1();
           btnResultados.Visible = false; 
        }
        private void Limpiar()
        {
            this.rbAlternativa1.Checked = false;
            this.rbAlternativa2.Checked = false;
            this.rbAlternativa3.Checked = false;
            this.rbAlternativa4.Checked = false;
        }
        private void pregunta1()
        {
            this.lblPregunta.Text = "1.¿ Cual de las siguientes alternativas NO es parte de la Calidad ? ";
            this.rbAlternativa1.Text = "Aptitud de uso";
            this.rbAlternativa2.Text = "Valor por el patrocinador";
            this.rbAlternativa3.Text = "Satisfacción del cliente";
            this.rbAlternativa4.Text = "Conformidad con los requisitos";
            seleccion++;

        }
        private void pregunta2()
        {
            this.lblPregunta.Text = "2. ¿Cuál de los siguientes NO es un ejemplo de Costo" +
                "de la Calidad(COQ)?";
            this.rbAlternativa1.Text = "Constractar inspectores adicionales para buscar defectos";
            this.rbAlternativa2.Text = "Hacer que los trabajadores utilicen tiempo extra para revisar requisitos" + "\r" +
                " de los interesados";
            this.rbAlternativa3.Text = "Pagar programadores adicionales para ayudar a cumplir con la fecha" + "\r" +
                "de entrega ";
            this.rbAlternativa4.Text = "Enviar a un equipo a reparar un producto" +
                "defectuoso que fue entregado al cliente";
            seleccion++;

        }
        private void pregunta3()
        {
            this.lblPregunta.Text = "3. ¿Cuál de los siguientes enunciados NO es parte del " +
                "Plan de Gestión de la Calidad?";
            this.rbAlternativa1.Text = "Métricas para medir la calidad de su proyecto";
            this.rbAlternativa2.Text = "Una descripción de que entregables no tienen que ser inspeccionados ";
            this.rbAlternativa3.Text = "Estrategias para encargarse de defectos y otros problemas de calidad" ;
            this.rbAlternativa4.Text = "Guía de cómo el equipo de Proyecto implementará la política de calidad de la compañía" ;
            seleccion++;
            
        }
        private void pregunta4()
        {
            this.lblPregunta.Text = "4. ¿Cuál de las siguientes herramientas y técnicas es utilizada para mostrar las categorías " +
                "de defectos más comunes?";
            this.rbAlternativa1.Text = "Diagramas de Pareto ";
            this.rbAlternativa2.Text = "Diagramas de Control ";
            this.rbAlternativa3.Text = "Diagramas de Comportamiento";
            this.rbAlternativa4.Text = "Diagramas de Flujo";
            seleccion++;
        }
        private void pregunta5()
        {
            this.lblPregunta.Text = "5. ¿Cuándo se realiza una inspección?";
            this.rbAlternativa1.Text = "En cualquier momento que se produzca a un entregable";
            this.rbAlternativa2.Text = "Al Final del proyecto";
            this.rbAlternativa3.Text = "Sólo antes de entregar el producto final";
            this.rbAlternativa4.Text = "Al inicio del proyecto";
            seleccion++;
        }
        private void pregunta6()
        {
            this.lblPregunta.Text = "6. ¿Qué herramienta de Control de Calidad es utilizada para analizar" +
                                    "procesos viéndolos gráficamente?";
            this.rbAlternativa1.Text = "Controlar la Calidad";
            this.rbAlternativa2.Text = "Gestionar la Calidad";
            this.rbAlternativa3.Text = "Aseguramiento de Calidad";
            this.rbAlternativa4.Text = "Planificar la Gestión de la Calidad";
            seleccion++;
        }
        private void pregunta7()
        {
            this.lblPregunta.Text = "7. ¿Cuál de los siguientes está asociado a la regla 80/20?" ;
            this.rbAlternativa1.Text = "Diagrama de Control";
            this.rbAlternativa2.Text = "Diagrama de Dispersión";
            this.rbAlternativa3.Text = "Diagrama de Pareto ";
            this.rbAlternativa4.Text = "Histograma";
            seleccion++;
        }
        private void pregunta8()
        {
            this.lblPregunta.Text = "8. ¿Cuál de las siguientes alternativas describe MEJOR la revisión de repación de defectos?";
            this.rbAlternativa1.Text = "Revisar el defecto reparado con el interesado para asegurarse que es aceptable";
            this.rbAlternativa2.Text = "Revisar el defecto reparado para asegurarse que está entre los limites del control";
            this.rbAlternativa3.Text = "Revisar el defecto reparado para asegurarse que fue arreglado apropiadamente";
            this.rbAlternativa4.Text = "Revisar el defecto reparado con el equipo para asegurarse que documenten las lecciones aprendidas";
            seleccion++;
        }
        private void pregunta9()
        {
            this.lblPregunta.Text = "9. ¿Una repación de defectos validada es una salidad de qué proceso?";
            this.rbAlternativa1.Text = "Cotrol integrado de cambios";
            this.rbAlternativa2.Text = "Controlar la calidad ";
            this.rbAlternativa3.Text = "Gestionar la Calidad";
            this.rbAlternativa4.Text = "Planificar la Gestión de la Calidad";
            seleccion++;
        }
        private void pregunta10()
        {
            this.lblPregunta.Text = "10. Un Director de Proyecto está utilizando un histograma para analisar defectos" +
                "encontrados por un equipo durante" +"\r" +" las actividades de inspección. ¿Qué proceso está desempeñando?";
            this.rbAlternativa1.Text = "Realizar el Aseguramiento de la Calidad";
            this.rbAlternativa2.Text = "Controlar la Calidad";
            this.rbAlternativa3.Text = "Planificar la Gestión de la Calidad";
            this.rbAlternativa4.Text = "Verificar el Alcance";

            seleccion++;
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            switch (seleccion)
            {
                case 1:
                    if (this.rbAlternativa2.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta2();
                    Limpiar();
                    break;

                case 2:
                    if (this.rbAlternativa3.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta3();
                    Limpiar();
                    break;

                case 3:
                    if (this.rbAlternativa2.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta4();
                    Limpiar();
                    break;

                case 4:
                    if (this.rbAlternativa1.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta5();
                    Limpiar();
                    break;

                case 5:
                    if (this.rbAlternativa1.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta6();
                    Limpiar();
                    break;

                case 6:
                    if (this.rbAlternativa1.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta7();
                    Limpiar();
                    break;

                case 7:
                    if (this.rbAlternativa3.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta8();
                    Limpiar();
                    break;

                case 8:
                    if (this.rbAlternativa3.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta9();
                    Limpiar();
                    break;
                case 9:
                    if (this.rbAlternativa2.Checked == true)
                    {
                        resultado++;
                    }
                    pregunta10();
                    Limpiar();
                    break;
                case 10:
                    if (this.rbAlternativa2.Checked == true)
                    {
                        resultado++;
                    }
                    if (resultado == 10)
                    {
                        MessageBox.Show(resultado.ToString(), "FELICITACIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnResultados.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Logro:  " + resultado.ToString() + "  Puntos", "Estudie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnResultados.Visible = true;
                    }

                    break;
                default:
                    break;
            }
        }

        private void BtnResultados_Click(object sender, EventArgs e)
        {
            Resultados objresultados = new Resultados();
            objresultados.Show();
        }
    }
}