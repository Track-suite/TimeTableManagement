using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    
        public class Location
        {
            private int buildId;
            private string buildName;
            private string roomName;
            private string roomType;
            private int capacity;

            public Location(int buildId, string buildName, string roomName, string roomType, int capacity)
            {
                this.buildId = buildId;
                this.buildName = buildName;
                this.roomName = roomName;
                this.roomType = roomType;
                this.capacity = capacity;

            }
            public Location()
            {
            }
            public int BuildId
            {
                get
                {
                    return this.buildId;
                }
                set
                {
                    this.buildId = value;
                }
            }
            public string BuildName
            {
                get
                {
                    return this.buildName;
                }
                set
                {
                    this.buildName = value;
                }
            }
            public string RoomName
            {
                get
                {
                    return this.roomName;
                }
                set
                {
                    this.roomName = value;
                }
            }
            public string RoomType
            {
                get
                {
                    return this.roomType;
                }
                set
                {
                    this.roomType = value;
                }
            }
            public int Capacity
            {
                get
                {
                    return this.capacity;
                }
                set
                {
                    this.capacity = value;
                }
            }




        }
    }


