﻿using System.Collections.Generic;

namespace TatehamaInterlockingConsole.Models
{
    /// <summary>
    /// 運用サーバーデータ格納クラス
    /// </summary>
    public class DatabaseOperational
    {
        private static readonly DatabaseOperational _instance = new();
        public static DatabaseOperational Instance => _instance;

        /// <summary>
        /// 連動装置・送信用データクラス
        /// </summary>
        public class DataToServer
        {
            /// <summary>
            /// 起動しているウィンドウの駅名
            /// </summary>
            public List<string> ActiveStationsList { get; set; }
            /// <summary>
            /// てこ・着点ボタン名
            /// </summary>
            public string PartsName { get; set; }
            /// <summary>
            /// てこの向き
            /// </summary>
            public int PartsValue { get; set; }
        }

        /// <summary>
        /// 連動装置・受信用データクラス
        /// </summary>
        public class DataFromServer
        {
            private InterlockingAuthentication _authentication;

            public InterlockingAuthentication Authentication
            {
                get => _authentication;
                set
                {
                    if (_authentication != null)
                    {
                        throw new System.InvalidOperationException("Authentication is already set. Only one instance is allowed.");
                    }
                    _authentication = value;
                }
            }
            public List<InterlockingTrackCircuit> TrackCircuits { get; set; } = [];
            public List<InterlockingPoint> Points { get; set; } = [];
            public List<InterlockingSignal> Signals { get; set; } = [];
            public List<InterlockingLamp> Lamps { get; set; } = [];
            public List<InterlockingRetsuban> Retsubans { get; set; } = [];
            public List<InterlockingLever> Levers { get; set; } = [];
        }

        /// <summary>
        /// 連動装置・認証情報クラス
        /// </summary>
        public class InterlockingAuthentication
        {
            /// <summary>
            /// 指令主任判定
            /// </summary>
            public bool IsCommander { get; set; }
            /// <summary>
            /// 信号係員判定
            /// </summary>
            public bool IsOperator { get; set; }
        }

        /// <summary>
        /// 連動装置・軌道回路情報クラス
        /// </summary>
        public class InterlockingTrackCircuit
        {
            /// <summary>
            /// 名称
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// 鎖錠判定
            /// </summary>
            public bool IsRouteSetting { get; set; }
            /// <summary>
            /// 在線判定
            /// </summary>
            public bool IsOnTrack { get; set; }
        }

        /// <summary>
        /// 連動装置・転てつ器情報クラス
        /// </summary>
        public class InterlockingPoint
        {
            /// <summary>
            /// 名称
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// 反位判定
            /// </summary>
            public bool IsReversePosition { get; set; }
        }

        /// <summary>
        /// 連動装置・信号機情報クラス
        /// </summary>
        public class InterlockingSignal
        {
            /// <summary>
            /// 名称
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// 進行信号判定
            /// </summary>
            public bool IsProceedSignal { get; set; }
        }

        /// <summary>
        /// 連動装置・ランプ情報クラス
        /// </summary>
        public class InterlockingLamp
        {
            /// <summary>
            /// 名称
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// 点灯判定
            /// </summary>
            public bool IsLighting { get; set; }
        }

        /// <summary>
        /// 連動装置・列番情報クラス
        /// </summary>
        public class InterlockingRetsuban
        {
            /// <summary>
            /// 名称
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// 列車番号情報
            /// </summary>
            public string RetsubanText { get; set; }
        }

        /// <summary>
        /// 連動装置・てこ情報クラス
        /// </summary>
        public class InterlockingLever
        {
            /// <summary>
            /// 名称
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// てこの向き
            /// </summary>
            public int LeverValue { get; set; }
        }
    }
}
