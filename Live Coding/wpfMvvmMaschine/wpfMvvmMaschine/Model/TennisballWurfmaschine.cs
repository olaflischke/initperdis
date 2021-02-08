﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace wpfMvvmMaschine.Model
{
    public class TennisballWurfmaschine : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        #region Lokale Variablen
        private DispatcherTimer timTimer;
        #endregion

        public TennisballWurfmaschine()
        {
            timTimer = new DispatcherTimer();
            timTimer.Tick += TimTimer_Tick;
        }

        private void TimTimer_Tick(object sender, EventArgs e)
        {
            this.Stueckzahl++;
        }


        #region Eigenschaften der Maschine
        private int _intSpeed;

        /// <summary>
        /// Geschwindigkeit, mit der die Bälle geworfen werden.
        /// </summary>
        public int Geschwindigkeit
        {
            get { return _intSpeed; }
            set
            {
                if (value > 0)
                {
                    _intSpeed = value;
                    timTimer.Interval = TimeSpan.FromMilliseconds(1000 / this.Geschwindigkeit);
                    OnPropertyChanged();
                }
            }
        }

        private int _intStueck;



        /// <summary>
        /// Anzahl der geworfenen Bälle.
        /// </summary>
        public int Stueckzahl
        {
            get { return _intStueck; }
            set
            {
                _intStueck = value;
                OnPropertyChanged();
            }
        }

        private bool _istAmLaufen;
        public bool IstAmLaufen
        {
            get => _istAmLaufen; set
            {
                _istAmLaufen = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Methoden
        public void Start()
        {
            timTimer.Interval = TimeSpan.FromMilliseconds(1000);
            timTimer.Start();
            this.Geschwindigkeit = 1;
            this.IstAmLaufen = true;
        }

        public void Stopp()
        {
            timTimer.Stop();
            IstAmLaufen = false;
        }
        #endregion

    }
}
