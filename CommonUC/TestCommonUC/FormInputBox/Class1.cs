using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace TestCommonUC.FormInputBox
{
    public class Class1:INotifyPropertyChanged
    {
        private int _id;
        [ClassAttribute(Name="编号",MaxLength=4)]
        public int id
        {
            get { return _id; }
            set { _id = value; this.Notify("id"); }
        }

        private string _name;
        [ClassAttribute(Name = "姓名hahahahwerhwerh", MaxLength = 10)]
        public string name
        {
            get { return _name; }
            set { _name = value; this.Notify("name"); }
        }

        private EnumSex _sex;
        [ClassAttribute(Name = "性别", MaxLength = 4)]
        public EnumSex sex
        {
            get { return _sex; }
            set { _sex = value; this.Notify("sex"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void Notify(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }

    public enum EnumSex
    {
        man,
        female
    }
}
