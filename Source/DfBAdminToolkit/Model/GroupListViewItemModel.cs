﻿namespace DfBAdminToolkit.Model {

    using System.ComponentModel;

    public class GroupListViewItemModel
        : INotifyPropertyChanged, IModel {
        private string _groupName;
        private string _groupId;
        private string _memberCount;
        private bool _isChecked;

        public string GroupName {
            get { return _groupName; }
            set {
                _groupName = value;
                OnPropertyChanged("GroupName");
            }
        }

        public string GroupId {
            get { return _groupId; }
            set {
                _groupId = value;
                OnPropertyChanged("GroupId");
            }
        }

        public string MemberCount {
            get { return _memberCount; }
            set {
                _memberCount = value;
                OnPropertyChanged("MemberCount");
            }
        }

        public bool IsChecked {
            get { return _isChecked; }
            set {
                _isChecked = value;
                OnPropertyChanged("IsChecked");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public GroupListViewItemModel() {
        }

        public void Initialize() {
        }

        public void CleanUp() {
        }

        private void OnPropertyChanged(string propName) {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) {
                handler(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}