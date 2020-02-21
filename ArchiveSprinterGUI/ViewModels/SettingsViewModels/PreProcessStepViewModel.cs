﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AS.Config;
using AS.Utilities;
using System.Collections.ObjectModel;
using AS.Core.ViewModels;

namespace ArchiveSprinterGUI.ViewModels.SettingsViewModels
{
    public class PreProcessStepViewModel : ViewModelBase
    {
        private PreProcessSetting _model;

        public ObservableCollection<SignalViewModel> _inputChannels;
        public ObservableCollection<SignalViewModel> InputChannels
        {
            get
            {
                return _inputChannels;
            }
            set
            {
                _inputChannels = value;
                OnPropertyChanged();
            }
        }

        public string Name { get; set; }

        public int StepCounter { get; set; }

        private bool _isSelected;
        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                OnPropertyChanged();
            }
        }

        private bool _isComplete;
        public bool IsComplete
        {
            get { return _isComplete; }
            set
            {
                _isComplete = value;
                OnPropertyChanged();
            }
        }

        public PreProcessStepViewModel()
        {
            _model = new PreProcessSetting();
            _isSelected = false;
            _isComplete = false;
            StepCounter = 0;
            InputChannels = new ObservableCollection<SignalViewModel>();
        }
    }
}
