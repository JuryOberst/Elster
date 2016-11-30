// <copyright file="XmlSchemaUtilities.cs" company="DATALINE GmbH &amp; Co. KG">
// Copyright (c) DATALINE GmbH &amp; Co. KG. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Dataline.Elster.Basis
{
    /// <summary>
    /// Hilfsfunktionen für die Handhabung von <see langword="enum"/>-Werten im XML-Schema-Kontext
    /// </summary>
    public static class XmlSchemaUtilities
    {
        private static readonly Dictionary<EnumMemberKey, string> _enumXmlCache = new Dictionary<EnumMemberKey, string>();

        private static readonly Dictionary<EnumMemberKey, object> _enumValueCache = new Dictionary<EnumMemberKey, object>();

        /// <summary>
        /// Holt den XML-Schema-Wert eines <see langword="enum"/>-Wertes
        /// </summary>
        /// <typeparam name="T">Der <see langword="enum"/>-Typ</typeparam>
        /// <param name="member">Der Wert vom Typ <typeparamref name="T"/></param>
        /// <returns>Der Text, der in die XML-Datei geschrieben werden muss</returns>
        public static string GetEnumXmlValue<T>(T member)
            where T : struct
        {
            var memberName = member.ToString();
            var type = typeof(T);
            var enumMemberKey = new EnumMemberKey(memberName, type);
            lock (_enumValueCache)
            {
                if (!_enumXmlCache.ContainsKey(enumMemberKey))
                {
                    var memberAttribute =
                        type.GetRuntimeField(memberName)
                            .GetCustomAttributes(typeof(System.Xml.Serialization.XmlEnumAttribute), true)
                            .OfType<System.Xml.Serialization.XmlEnumAttribute>()
                            .Select(y => new
                            {
                                Member = memberName,
                                Attr = y
                            }).FirstOrDefault();
                    var xmlValue = (memberAttribute == null) ? memberName : memberAttribute.Attr.Name;
                    _enumXmlCache.Add(enumMemberKey, xmlValue);
                    return xmlValue;
                }
                var result = _enumXmlCache[enumMemberKey];
                System.Diagnostics.Debug.Assert(result != null, string.Format("Der Wert für {0}.{1} darf nicht null sein.", type, memberName));
                return result;
            }
        }

        /// <summary>
        /// Holt den <see langword="enum"/>-Wert anhand eines XML-Schema-Enum-Wertes
        /// </summary>
        /// <typeparam name="T">Der <see langword="enum"/>-Typ</typeparam>
        /// <param name="memberName">Der XML-Schema-Enum-Wert, der umgewandelt werden soll</param>
        /// <returns>Ein Wert vom Typ <typeparamref name="T"/></returns>
        public static T GetXmlEnumValue<T>(string memberName)
            where T : struct
        {
            memberName = memberName.Trim();
            var type = typeof(T);
            var enumMemberKey = new EnumMemberKey(memberName, type);
            if (!_enumValueCache.ContainsKey(enumMemberKey))
            {
                var memberAttributes = type
                    .GetRuntimeFields()
                    .Where(x => x.IsStatic)
                    .SelectMany(
                        x => x.GetCustomAttributes(typeof(System.Xml.Serialization.XmlEnumAttribute), true)
                            .OfType<System.Xml.Serialization.XmlEnumAttribute>()
                            .Select(y => new
                            {
                                Member = x,
                                Attr = y
                            })
                            .ToList())
                    .ToList();
                foreach (var memberAttribute in memberAttributes)
                {
                    if (string.Equals(memberAttribute.Attr.Name, memberName, StringComparison.CurrentCulture))
                    {
                        var value = (T)memberAttribute.Member.GetValue(null);
                        _enumValueCache.Add(enumMemberKey, value);
                        return value;
                    }
                }

                var field = type.GetRuntimeField(memberName);
                if (field == null)
                    throw new ArgumentOutOfRangeException(string.Format("Der Wert {0} kann nicht dem Enum-Typen {1} zugeordnet werden.", memberName, type.FullName), "memberName");

                var fieldValue = (T)field.GetValue(null);
                _enumValueCache.Add(enumMemberKey, fieldValue);
                return fieldValue;
            }
            var result = _enumValueCache[enumMemberKey];
            System.Diagnostics.Debug.Assert(result != null, string.Format("Der Wert für {0}.{1} darf nicht null sein.", type, memberName));
            return (T)result;
        }

        private class EnumMemberKey : IComparable<EnumMemberKey>, IEquatable<EnumMemberKey>
        {
            private readonly string _memberName;
            private readonly Type _type;

            public EnumMemberKey(string memberName, Type type)
            {
                _memberName = memberName;
                _type = type;
            }

            public int CompareTo(EnumMemberKey other)
            {
                if (_type.FullName != other._type.FullName)
                    return StringComparer.Ordinal.Compare(_type.FullName, other._type.FullName);
                return StringComparer.Ordinal.Compare(_memberName, other._memberName);
            }

            public bool Equals(EnumMemberKey other)
            {
                return CompareTo(other) == 0;
            }

            public override bool Equals(object obj)
            {
                return Equals((EnumMemberKey)obj);
            }

            public override int GetHashCode()
            {
                return _type.GetHashCode() ^ _memberName.GetHashCode();
            }
        }
    }
}
