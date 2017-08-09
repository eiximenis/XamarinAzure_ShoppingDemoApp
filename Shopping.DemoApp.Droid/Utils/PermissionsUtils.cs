using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Plugin.Permissions;
using System.Threading.Tasks;

namespace Shopping.DemoApp.Droid.Utils
{
    static class PermissionsUtils
    {
        private static async Task<Dictionary<Plugin.Permissions.Abstractions.Permission, Plugin.Permissions.Abstractions.PermissionStatus>> CheckPermissionsAsync()
        {
            return await CrossPermissions.Current.RequestPermissionsAsync(new[] { Plugin.Permissions.Abstractions.Permission.Camera, Plugin.Permissions.Abstractions.Permission.Storage });
        }

        public static async Task<bool> CheckPermissions()
        {
            var cameraStatus = CrossPermissions.Current.CheckPermissionStatusAsync(Plugin.Permissions.Abstractions.Permission.Camera).Result;
            var storageStatus = CrossPermissions.Current.CheckPermissionStatusAsync(Plugin.Permissions.Abstractions.Permission.Storage).Result;
            bool granted = cameraStatus == Plugin.Permissions.Abstractions.PermissionStatus.Granted && storageStatus == Plugin.Permissions.Abstractions.PermissionStatus.Granted;

            if (!granted)
            {
                var results = await CheckPermissionsAsync();
                cameraStatus = results[Plugin.Permissions.Abstractions.Permission.Camera];
                storageStatus = results[Plugin.Permissions.Abstractions.Permission.Storage];
                granted = cameraStatus == Plugin.Permissions.Abstractions.PermissionStatus.Granted && storageStatus == Plugin.Permissions.Abstractions.PermissionStatus.Granted;
            }

            return granted;
        }

    }
}