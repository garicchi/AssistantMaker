﻿using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CortanaCommand.ViewModel
{
    public class StateViewModel:ViewModelBase
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                this.Set(ref _name, value);
            }
        }

        public string Example
        {
            get
            {
                return _example;
            }

            set
            {
                this.Set(ref _example,value);
            }
        }

        private string _example;

        public string ListenFor
        {
            get
            {
                return _listenFor;
            }

            set
            {
                this.Set(ref _listenFor,value);
            }
        }

        public string FeedBack
        {
            get
            {
                return _feedBack;
            }

            set
            {
                this.Set(ref _feedBack,value);
            }
        }

        private string _listenFor;

        private string _feedBack;

        public string Script
        {
            get
            {
                return _script;
            }

            set
            {
                this.Set(ref _script, value);
            }
        }

        private string _script;

        private string _protocol;

        public string Protocol
        {
            get { return _protocol; }
            set { this.Set(ref _protocol, value); }
        }


        public StateViewModel()
        {
            Example = "こんにちはコルタナ";
            ListenFor = "[こんにちは]コルタナ";
            FeedBack = ".";
        }

        
    }
}
