using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.UnityUtils
{
    /// <summary>
    /// 4-Vector struct of sbyte [CvType.CV_8SC4]
    /// </summary>
    [Serializable]
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Vec4c : IComparable, IComparable<Vec4c>, IEquatable<Vec4c>, IStructuralComparable, IStructuralEquatable
    {
        public sbyte Item1;
        public sbyte Item2;
        public sbyte Item3;
        public sbyte Item4;

        public Vec4c(sbyte item1 = 0, sbyte item2 = 0, sbyte item3 = 0, sbyte item4 = 0)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
        }

        public readonly Vec4b ToVec4b() => new Vec4b((byte)Item1, (byte)Item2, (byte)Item3, (byte)Item4);
        public readonly Vec4w ToVec4w() => new Vec4w((ushort)Item1, (ushort)Item2, (ushort)Item3, (ushort)Item4);
        public readonly Vec4s ToVec4s() => new Vec4s((short)Item1, (short)Item2, (short)Item3, (short)Item4);
        public readonly Vec4i ToVec4i() => new Vec4i((int)Item1, (int)Item2, (int)Item3, (int)Item4);
        public readonly Vec4f ToVec4f() => new Vec4f((float)Item1, (float)Item2, (float)Item3, (float)Item4);
        public readonly Vec4d ToVec4d() => new Vec4d((double)Item1, (double)Item2, (double)Item3, (double)Item4);

        // IComparable implementation
        public readonly int CompareTo(object obj)
        {
            if (obj is Vec4c other)
            {
                return CompareTo(other);
            }
            throw new ArgumentException("Object is not a Vec4c");
        }

        // IComparable<Vec4c> implementation
        public readonly int CompareTo(Vec4c other)
        {
            int result = Item1.CompareTo(other.Item1);
            if (result != 0)
            {
                return result;
            }
            result = Item2.CompareTo(other.Item2);
            if (result != 0)
            {
                return result;
            }
            result = Item3.CompareTo(other.Item3);
            if (result != 0)
            {
                return result;
            }
            return Item4.CompareTo(other.Item4);
        }

        // IEquatable<Vec4c> implementation
        public readonly bool Equals(Vec4c other)
        {
            return Item1 == other.Item1 && Item2 == other.Item2 && Item3 == other.Item3 && Item4 == other.Item4;
        }

        // Equals(object) override
        public override readonly bool Equals(object obj)
        {
            if (obj is Vec4c other)
            {
                return Equals(other);
            }
            return false;
        }

        // GetHashCode override
        public override readonly int GetHashCode()
        {
#if NET_STANDARD_2_1
            return HashCode.Combine(Item1, Item2, Item3, Item4);
#else
            unchecked
            {
                int hash = 17;
                hash = hash * 31 + Item1.GetHashCode();
                hash = hash * 31 + Item2.GetHashCode();
                hash = hash * 31 + Item3.GetHashCode();
                hash = hash * 31 + Item4.GetHashCode();
                return hash;
            }
#endif
        }

        // IStructuralComparable implementation
        public readonly int CompareTo(object other, IComparer comparer)
        {
            if (other is Vec4c otherTuple)
            {
                int result = comparer.Compare(Item1, otherTuple.Item1);
                if (result != 0)
                {
                    return result;
                }
                result = comparer.Compare(Item2, otherTuple.Item2);
                if (result != 0)
                {
                    return result;
                }
                result = comparer.Compare(Item3, otherTuple.Item3);
                if (result != 0)
                {
                    return result;
                }
                return comparer.Compare(Item4, otherTuple.Item4);
            }
            throw new ArgumentException("Object is not a Vec4c");
        }

        // IStructuralEquatable implementation
        public readonly bool Equals(object other, IEqualityComparer comparer)
        {
            if (other is Vec4c otherTuple)
            {
                return comparer.Equals(Item1, otherTuple.Item1) && comparer.Equals(Item2, otherTuple.Item2) && comparer.Equals(Item3, otherTuple.Item3) && comparer.Equals(Item4, otherTuple.Item4);
            }
            return false;
        }

        public readonly int GetHashCode(IEqualityComparer comparer)
        {
            return comparer.GetHashCode(Item1) ^ comparer.GetHashCode(Item2) ^ comparer.GetHashCode(Item3) ^ comparer.GetHashCode(Item4);
        }

        // ToString override
        public override readonly string ToString()
        {
            return $"({Item1}, {Item2}, {Item3}, {Item4})";
        }

        // Equality operators
        public static bool operator ==(Vec4c left, Vec4c right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Vec4c left, Vec4c right)
        {
            return !(left == right);
        }

        // explicit conversion to ValueTuple<sbyte, sbyte, sbyte, sbyte>
        public static explicit operator (sbyte, sbyte, sbyte, sbyte)(in Vec4c vec)
        {
            return (vec.Item1, vec.Item2, vec.Item3, vec.Item4);
        }

        // explicit conversion from ValueTuple<sbyte, sbyte, sbyte, sbyte>
        public static explicit operator Vec4c(in (sbyte, sbyte, sbyte, sbyte) valueTuple)
        {
            return new Vec4c(valueTuple.Item1, valueTuple.Item2, valueTuple.Item3, valueTuple.Item4);
        }

        public readonly (sbyte, sbyte, sbyte, sbyte) ToValueTuple() => (Item1, Item2, Item3, Item4);
    }
}
