﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using WarThunderComparer.comparerData.Adapters;
using WarThunderComparer.comparerData.Collections;
using Android.Widget;

namespace WarThunderComparer.comparerData.Collections
{
    class TaskCollection
    {
        public static List<Task> GetTask()
        {
            Context context = Application.Context;

            List<Task> tasks = new List<Task>();
            Task task = null;

    
            task = new Task();
            task.Id = 1;
            task.Name = context.Resources.GetString(Resource.String.PlaneTask1);
            tasks.Add(task);

            task = new Task();
            task.Id = 2;
            task.Name = context.Resources.GetString(Resource.String.PlaneTask2);
            tasks.Add(task);

            task = new Task();
            task.Id = 3;
            task.Name = context.Resources.GetString(Resource.String.PlaneTask3);
            tasks.Add(task);

            task = new Task();
            task.Id = 4;
            task.Name = context.Resources.GetString(Resource.String.PlaneTask4);
            tasks.Add(task);


            task = new Task();
            task.Id = 5;
            task.Name = context.Resources.GetString(Resource.String.PlaneTask5);
            tasks.Add(task);

            task = new Task();
            task.Id = 6;
            task.Name = context.Resources.GetString(Resource.String.PlaneTask6);
            tasks.Add(task);

            task = new Task();
            task.Id = 7;
            task.Name = context.Resources.GetString(Resource.String.PlaneTask7);
            tasks.Add(task);

            return tasks;
        }

    }
}