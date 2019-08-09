using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preguntas
{
    public partial class Resultados : Form
    {
        public Resultados()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Resultados_Load(object sender, EventArgs e)
        {
            this.lblPregunta1.Text = "1.¿ Cual de las siguientes alternativas NO es parte de la Calidad ? ";
            this.rbAlternativa11.Text = "Aptitud de uso";
            this.rbAlternativa12.Text = "Valor por el patrocinador";
            this.rbAlternativa12.ForeColor = Color.Violet;
            this.rbAlternativa13.Text = "Satisfacción del cliente";
            this.rbAlternativa14.Text = "Conformidad con los requisitos";

            this.lblPregunta2.Text = "2. ¿Cuál de los siguientes NO es un ejemplo de Costo" +
                "de la Calidad(COQ)?";
            this.rbAlternativa21.Text = "Constractar inspectores adicionales para buscar defectos";
            this.rbAlternativa22.Text = "Hacer que los trabajadores utilicen tiempo extra para revisar requisitos" + "\r" +
                " de los interesados";
            this.rbAlternativa23.Text = "Pagar programadores adicionales para ayudar a cumplir con la fecha" + "\r" +
                "de entrega ";
            this.rbAlternativa23.ForeColor = Color.Violet;
            this.rbAlternativa24.Text = "Enviar a un equipo a reparar un producto" +
                "defectuoso que fue entregado al cliente";

            this.lblPregunta3.Text = "3. ¿Cuál de los siguientes enunciados NO es parte del " +
                "Plan de Gestión de la Calidad?";
            this.rbAlternativa31.Text = "Métricas para medir la calidad de su proyecto";
            this.rbAlternativa32.Text = "Una descripción de que entregables no tienen que ser inspeccionados ";
            this.rbAlternativa32.ForeColor = Color.Violet;
            this.rbAlternativa33.Text = "Estrategias para encargarse de defectos y otros problemas de calidad";
            this.rbAlternativa34.Text = "Guía de cómo el equipo de Proyecto implementará la política de calidad de la compañía";

            this.lblPregunta4.Text = "4. ¿Cuál de las siguientes herramientas y técnicas es utilizada para mostrar las categorías " +
                "de defectos más comunes?";
            this.rbAlternativa41.Text = "Diagramas de Pareto ";
            this.rbAlternativa41.ForeColor = Color.Violet;
            this.rbAlternativa42.Text = "Diagramas de Control ";
            this.rbAlternativa43.Text = "Diagramas de Comportamiento";
            this.rbAlternativa44.Text = "Diagramas de Flujo";

            this.lblPregunta5.Text = "5. ¿Cuándo se realiza una inspección?";
            this.rbAlternativa51.Text = "En cualquier momento que se produzca a un entregable";
            this.rbAlternativa51.ForeColor = Color.Violet;
            this.rbAlternativa52.Text = "Al Final del proyecto";
            this.rbAlternativa53.Text = "Sólo antes de entregar el producto final";
            this.rbAlternativa54.Text = "Al inicio del proyecto";

            this.lblPregunta6.Text = "6. ¿Qué herramienta de Control de Calidad es utilizada para analizar" +
                        "procesos viéndolos gráficamente?";
            this.rbAlternativa61.Text = "Controlar la Calidad";
            this.rbAlternativa61.ForeColor = Color.Violet;
            this.rbAlternativa62.Text = "Gestionar la Calidad";
            this.rbAlternativa63.Text = "Aseguramiento de Calidad";
            this.rbAlternativa64.Text = "Planificar la Gestión de la Calidad";

            this.lblPregunta7.Text = "7. ¿Cuál de los siguientes está asociado a la regla 80/20?";
            this.rbAlternativa71.Text = "Diagrama de Control";
            this.rbAlternativa72.Text = "Diagrama de Dispersión";
            this.rbAlternativa73.Text = "Diagrama de Pareto ";
            this.rbAlternativa73.ForeColor = Color.Violet;
            this.rbAlternativa74.Text = "Histograma";


            this.lblPregunta8.Text = "8. ¿Cuál de las siguientes alternativas describe MEJOR la revisión de repación de defectos?";
            this.rbAlternativa81.Text = "Revisar el defecto reparado con el interesado para asegurarse que es aceptable";
            this.rbAlternativa82.Text = "Revisar el defecto reparado para asegurarse que está entre los limites del control";
            this.rbAlternativa83.Text = "Revisar el defecto reparado para asegurarse que fue arreglado apropiadamente";
            this.rbAlternativa83.ForeColor = Color.Violet;
            this.rbAlternativa84.Text = "Revisar el defecto reparado con el equipo para asegurarse que documenten las lecciones aprendidas";

            this.lblPregunta9.Text = "9. ¿Una repación de defectos validada es una salidad de qué proceso?";
            this.rbAlternativa91.Text = "Cotrol integrado de cambios";
            this.rbAlternativa92.Text = "Controlar la calidad ";
            this.rbAlternativa92.ForeColor = Color.Violet;
            this.rbAlternativa93.Text = "Gestionar la Calidad";
            this.rbAlternativa94.Text = "Planificar la Gestión de la Calidad";

            this.lblPregunta10.Text = "10. Un Director de Proyecto está utilizando un histograma para analisar defectos" +
            "encontrados por un equipo durante" + "\r" + " las actividades de inspección. ¿Qué proceso está desempeñando?";
            this.rbAlternativa101.Text = "Realizar el Aseguramiento de la Calidad";
            this.rbAlternativa102.Text = "Controlar la Calidad";
            this.rbAlternativa102.ForeColor = Color.Violet;
            this.rbAlternativa103.Text = "Planificar la Gestión de la Calidad";
            this.rbAlternativa104.Text = "Verificar el Alcance";


        }
    }
}
