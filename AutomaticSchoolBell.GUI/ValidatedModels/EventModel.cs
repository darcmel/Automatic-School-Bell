﻿using System;
using System.ComponentModel.DataAnnotations;

namespace AutomaticSchoolBell.GUI
{
    public class EventModel:ValidatedEditableBindableBase<EventModel>
    {

        protected override EventModel Property
        {
            get
            {
                return new EventModel
                {
                    Id = _id,
                    Date = _date,
                    StartTime = _startTime,
                    Description = _description,
                    AudioLocation = _audioLocation,
                    PlayerLocation = _playerLocation
                };
            }
            set
            {
                EventModel model = value;
                if(model!=null)
                {
                    Id = model.Id;
                    Date = model.Date;
                    StartTime = model.StartTime;
                    Description = model.Description;
                    AudioLocation = model.AudioLocation;
                    PlayerLocation = model.PlayerLocation;
                }
            }
        }

        private int _id;
        private DateTime _date;
        private TimeSpan _startTime;
        private string _description;
        private string _audioLocation;
        private string _playerLocation;
        private bool _isChecked;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                OnPropertyChanged(ref _id, value, nameof(Id));
            }
        }

        [Required]
        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                OnPropertyChanged(ref _date, value, nameof(Date));
            }
        }

        [Required]
        public TimeSpan StartTime
        {
            get
            {
                return _startTime;
            }
            set
            {
                OnPropertyChanged(ref _startTime, value, nameof(StartTime));
            }
        }

        [Required]
        [StringLength(250)]
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                OnPropertyChanged(ref _description, value, nameof(Description));
            }
        }
        [Required]
        public string AudioLocation
        {
            get
            {
                return _audioLocation;
            }
            set
            {
                OnPropertyChanged(ref _audioLocation, value, nameof(AudioLocation));
            }
        }
        public string PlayerLocation
        {
            get
            {
                return _playerLocation;
            }
            set
            {
                OnPropertyChanged(ref _playerLocation, value, nameof(PlayerLocation));
            }
        }
        public bool IsChecked
        {
            get
            {
                return _isChecked;
            }
            set
            {
                OnPropertyChanged(ref _isChecked, value, nameof(IsChecked));
            }
        }
    }
}
