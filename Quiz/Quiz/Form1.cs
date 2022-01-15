using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Question
        {
            //[JsonProperty("id")] int id;
            [JsonProperty("question")] public string question;
            //[JsonProperty("description")] string description;
            [JsonProperty("answers")] public Dictionary<string, string> answers;
            //[JsonProperty("multiple_correct_answers")] public bool mul_correct_answers;
            [JsonProperty("correct_answers")] public Dictionary<string, string> correct_answers;
            //[JsonProperty("correct_answer")] public string correct_answer;
            //[JsonProperty("explanation")] string explanation;
            //[JsonProperty("tip")] string tip;
            //[JsonProperty("tags")] List<Dictionary<string, string>> tags;
            //[JsonProperty("category")] string category;
            //[JsonProperty("difficulty")] string difficulty;
        };

        List<Question> response;
        int question_index;
        int question_count {
            get { return response.Count; }
        }

        Dictionary<string, RadioButton> answer_selectors = new Dictionary<string, RadioButton>();
        bool[] answer_registry;

        private void display_question(int index)
        {
            var question = response[index];
            lbl_pergunta.Text = question.question;
            lbl_num_pergunta.Text = (question_index + 1).ToString();
            flp_respostas.Controls.Clear();
            question.answers.Where(x => x.Value != null).ToList().ForEach(answer =>
            {
                var radioButton1 = new RadioButton();

                // 
                // radioButton1
                // 
                radioButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                radioButton1.Location = new System.Drawing.Point(3, 3);
                radioButton1.Name = "radioButton1";
                radioButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
                radioButton1.Size = new System.Drawing.Size(287, 53);
                radioButton1.TabIndex = 0;
                radioButton1.TabStop = true;
                radioButton1.UseVisualStyleBackColor = true;

                radioButton1.Text = answer.Value;
                flp_respostas.Controls.Add(radioButton1);
                answer_selectors[answer.Key] = radioButton1;
            });
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            question_index = 0;
            btn_prev.Enabled = false;

            var num_perguntas = (int)nud_perguntas.Value;
            var apikey = "diJKOCt5fc4RsN7OSAGPyEUL426NHZHngvEnsu9I";
            var json = new WebClient().DownloadString($"https://quizapi.io/api/v1/questions?apiKey={apikey}&limit={num_perguntas}");
            response = JsonConvert.DeserializeObject<List<Question>>(json);

            answer_registry = new bool[question_count];

            pnl_inicial.Visible = false;
            pnl_questoes.Visible = true;

            display_question(0);
        }

        private void add_result(string question, string answer, bool write)
        {
            var lbl_q = new Label();
            var lbl_r = new Label();
            var lbl_d = new Label();
            // 
            // lbl_q
            // 
            lbl_q.Location = new System.Drawing.Point(3, 0);
            lbl_q.Name = "lbl_q";
            lbl_q.Size = new System.Drawing.Size(290, 71);
            lbl_q.TabIndex = 0;
            lbl_q.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_r
            // 
            lbl_r.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_r.Location = new System.Drawing.Point(3, 71);
            lbl_r.Name = "lbl_r";
            lbl_r.Size = new System.Drawing.Size(290, 46);
            lbl_r.TabIndex = 0;
            lbl_r.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_d
            // 
            lbl_d.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            lbl_d.Location = new System.Drawing.Point(3, 117);
            lbl_d.Name = "lbl_d";
            lbl_d.Size = new System.Drawing.Size(290, 1);
            lbl_d.TabIndex = 1;

            lbl_q.ForeColor = write ? Color.Green : Color.Red;
            lbl_q.Text = question;
            lbl_r.ForeColor = write ? Color.Green : Color.Red;
            lbl_r.Text = answer;

            flp_resultados.Controls.Add(lbl_q);
            flp_resultados.Controls.Add(lbl_r);
            flp_resultados.Controls.Add(lbl_d);
        }
        private void show_results()
        {
            var erradas = answer_registry.Where(x => x == false).Count();
            lbl_resultado_resumo.Text = $"{erradas}/{question_count} respostas erradas!";
            lbl_resultado_resumo.ForeColor = erradas == 0 ? Color.Green : Color.Red;
            flp_resultados.Controls.Clear();
            for (int i = 0; i < question_count; i++)
            {
                var question = response[i];
                var answers = new List<string>();

                question.correct_answers.Where(x => x.Value == "true").ToList().ForEach(x => {
                    answers.Add(question.answers[x.Key.Substring(0, 8)]);
                });
                add_result(question.question, string.Join("; ", answers), answer_registry[i]);
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (answer_selectors.Where(x => x.Value.Checked).Count() != 0)
            {
                lbl_warning.Text = "";
                var question = response[question_index];
                answer_registry[question_index] = false;
                question.correct_answers.Where(x => x.Value == "true").ToList().ForEach(x =>
                {
                    var correct = x.Key.Substring(0, 8);
                    if (answer_selectors[correct].Checked)
                    {
                        answer_registry[question_index] = true;
                        return;
                    }
                });
                if (question_index + 1 >= question_count)
                {
                    pnl_questoes.Visible = false;
                    pnl_resultados.Visible = true;
                    show_results();
                }
                else
                {
                    btn_prev.Enabled = true;
                    display_question(++question_index);
                }
            }
            else
            {
                lbl_warning.Text = "Por favor Selecione uma resposta!";
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (question_index - 1 >= 0)
            {
                question_index--;

                if (question_index == 0) btn_prev.Enabled = false;
                display_question(question_index);
            }
        }

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            pnl_questoes.Visible = false;
            pnl_resultados.Visible = false;
            pnl_inicial.Visible = true;
        }
    }
}
