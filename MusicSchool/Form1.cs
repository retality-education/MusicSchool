using System;
using System.Windows.Forms;

namespace MusicSchool
{
    public partial class Form1 : Form
    {
        private MusicSchoolController _controller;

        public Form1()
        {
            InitializeComponent();

            var model = new MusicSchool();
            var view = new MusicSchoolControl(model, this);
            _controller = new MusicSchoolController(model, view);

            Controls.Add(view);
            this.Load += async (s, e) => await _controller.StartLessons();
        }
    }
}
