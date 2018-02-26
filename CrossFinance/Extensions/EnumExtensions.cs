using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;

namespace CrossFinance.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplayNameIfExist(this Enum enumValue)
        {
            DisplayAttribute displayAttribute = getDisplayAtribute(enumValue);
            if (displayAttribute == null)
            {
                return enumValue.ToString();
            }
            else
            {
                return displayAttribute.GetName();
            }
        }

        private static DisplayAttribute getDisplayAtribute<T>(T value)
            {
                return value.GetType()
                    .GetMember(value.ToString())
                    .FirstOrDefault()
                    .GetCustomAttribute<DisplayAttribute>();
            }
        }
    }