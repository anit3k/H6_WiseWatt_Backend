﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations.Schema;

namespace H6_WiseWatt_Backend.MongoData.Models
{
    public class DeviceDbModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string UserGuid { get; set; }

        public string DeviceType { get; set; }

        public string DeviceName { get; set; }

        public string Serial { get; set; }

        public bool IsManuallyOperated { get; set; }
        public bool IsOn { get; set; }

        public double EnergyConsumption { get; set; }

        [Column(TypeName = "time")]
        public TimeSpan OnTime { get; set; }

        [Column(TypeName = "time")]
        public TimeSpan OffTime { get; set; }
        public int Degree { get; set; }
    }
}
