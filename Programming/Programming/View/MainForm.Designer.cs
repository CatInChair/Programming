using Programming.View.Pages;
using System.Windows.Forms;

namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageEnums = new System.Windows.Forms.TabPage();
            this.tabPageClasses = new System.Windows.Forms.TabPage();
            this.tabPageFilms = new System.Windows.Forms.TabPage();
            this.tabPageRectangles = new System.Windows.Forms.TabPage();
            this.rectangleCollisionControl = new Programming.View.Pages.RectangleCollisionControl();
            this.filmsControl = new FilmsControl();
            this.enumsControl = new EnumsControl(this);
            this.classesControl = new ClassesControl();
            this.tabControl.SuspendLayout();
            this.tabPageRectangles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageEnums);
            this.tabControl.Controls.Add(this.tabPageClasses);
            this.tabControl.Controls.Add(this.tabPageFilms);
            this.tabControl.Controls.Add(this.tabPageRectangles);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(734, 561);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl.TabIndex = 0;
            //
            // enumsControl
            //
            this.enumsControl.Dock = DockStyle.Fill;
            // 
            // tabPageEnums
            // 
            this.tabPageEnums.BackColor = System.Drawing.Color.White;
            this.tabPageEnums.Location = new System.Drawing.Point(4, 22);
            this.tabPageEnums.Name = "tabPageEnums";
            this.tabPageEnums.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEnums.Size = new System.Drawing.Size(726, 535);
            this.tabPageEnums.TabIndex = 0;
            this.tabPageEnums.Text = "Enums";
            this.tabPageEnums.Controls.Add(this.enumsControl);
            //
            // classesControl
            //
            this.classesControl.Dock = DockStyle.Fill;
            // 
            // tabPageClasses
            // 
            this.tabPageClasses.BackColor = System.Drawing.Color.White;
            this.tabPageClasses.Location = new System.Drawing.Point(4, 22);
            this.tabPageClasses.Name = "tabPageClasses";
            this.tabPageClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClasses.Size = new System.Drawing.Size(726, 535);
            this.tabPageClasses.TabIndex = 1;
            this.tabPageClasses.Text = "Classes";
            this.tabPageClasses.Controls.Add(this.classesControl);
            //
            // filmsControl
            //
            this.filmsControl.Dock = DockStyle.Fill;
            // 
            // tabPageFilms
            // 
            this.tabPageFilms.BackColor = System.Drawing.Color.White;
            this.tabPageFilms.Location = new System.Drawing.Point(4, 22);
            this.tabPageFilms.Name = "tabPageFilms";
            this.tabPageFilms.Size = new System.Drawing.Size(726, 535);
            this.tabPageFilms.TabIndex = 2;
            this.tabPageFilms.Text = "Films";
            this.tabPageFilms.Controls.Add(this.filmsControl);
            // 
            // tabPageRectangles
            // 
            this.tabPageRectangles.AutoScroll = true;
            this.tabPageRectangles.BackColor = System.Drawing.Color.White;
            this.tabPageRectangles.Controls.Add(this.rectangleCollisionControl);
            this.tabPageRectangles.Location = new System.Drawing.Point(4, 22);
            this.tabPageRectangles.Name = "tabPageRectangles";
            this.tabPageRectangles.Size = new System.Drawing.Size(726, 535);
            this.tabPageRectangles.TabIndex = 3;
            this.tabPageRectangles.Text = "Rectangles";
            // 
            // rectangleCollisionControl
            // 
            this.rectangleCollisionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectangleCollisionControl.Location = new System.Drawing.Point(0, 0);
            this.rectangleCollisionControl.Name = "rectangleCollisionControl";
            this.rectangleCollisionControl.Size = new System.Drawing.Size(726, 535);
            this.rectangleCollisionControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Programming";
            this.tabControl.ResumeLayout(false);
            this.tabPageRectangles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageEnums;
        private TabPage tabPageClasses;
        private TabPage tabPageFilms;
        private TabPage tabPageRectangles;
        private RectangleCollisionControl rectangleCollisionControl;
        private FilmsControl filmsControl;
        private ClassesControl classesControl;
        private EnumsControl enumsControl;
    }
}

