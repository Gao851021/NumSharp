// Copyright (c) 2019 by the SciSharp Team
// Code generated by CodeMinion: https://github.com/SciSharp/CodeMinion

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using Python.Included;
using Numpy.Models;

namespace Numpy
{
    public static partial class np
    {
        
        /// <summary>
        /// Test whether all array elements along a given axis evaluate to True.
        /// 
        /// Notes
        /// 
        /// Not a Number (NaN), positive infinity and negative infinity
        /// evaluate to True because these are not equal to zero.
        /// </summary>
        /// <param name="a">
        /// Input array or object that can be converted to an array.
        /// </param>
        /// <param name="axis">
        /// Axis or axes along which a logical AND reduction is performed.
        /// The default (axis = None) is to perform a logical AND over all
        /// the dimensions of the input array. axis may be negative, in
        /// which case it counts from the last to the first axis.
        /// 
        /// If this is a tuple of ints, a reduction is performed on multiple
        /// axes, instead of a single axis or all the axes as before.
        /// </param>
        /// <param name="@out">
        /// Alternate output array in which to place the result.
        /// It must have the same shape as the expected output and its
        /// type is preserved (e.g., if dtype(out) is float, the result
        /// will consist of 0.0’s and 1.0’s).  See doc.ufuncs (Section
        /// “Output arguments”) for more details.
        /// </param>
        /// <param name="keepdims">
        /// If this is set to True, the axes which are reduced are left
        /// in the result as dimensions with size one. With this option,
        /// the result will broadcast correctly against the input array.
        /// 
        /// If the default value is passed, then keepdims will not be
        /// passed through to the all method of sub-classes of
        /// ndarray, however any non-default value will be.  If the
        /// sub-class’ method does not implement keepdims any
        /// exceptions will be raised.
        /// </param>
        /// <returns>
        /// A new boolean or array is returned unless out is specified,
        /// in which case a reference to out is returned.
        /// </returns>
        public static NDarray<bool> all(NDarray a, int[] axis, NDarray @out = null, bool? keepdims = null)
            => NumPy.Instance.all(a, axis:axis, @out:@out, keepdims:keepdims);
        
        /// <summary>
        /// Test whether all array elements along a given axis evaluate to True.
        /// 
        /// Notes
        /// 
        /// Not a Number (NaN), positive infinity and negative infinity
        /// evaluate to True because these are not equal to zero.
        /// </summary>
        /// <param name="a">
        /// Input array or object that can be converted to an array.
        /// </param>
        /// <returns>
        /// A new boolean or array is returned unless out is specified,
        /// in which case a reference to out is returned.
        /// </returns>
        public static bool all(NDarray a)
            => NumPy.Instance.all(a);
        
        /// <summary>
        /// Test whether any array element along a given axis evaluates to True.
        /// 
        /// Returns single boolean unless axis is not None
        /// 
        /// Notes
        /// 
        /// Not a Number (NaN), positive infinity and negative infinity evaluate
        /// to True because these are not equal to zero.
        /// </summary>
        /// <param name="a">
        /// Input array or object that can be converted to an array.
        /// </param>
        /// <param name="axis">
        /// Axis or axes along which a logical OR reduction is performed.
        /// The default (axis = None) is to perform a logical OR over all
        /// the dimensions of the input array. axis may be negative, in
        /// which case it counts from the last to the first axis.
        /// 
        /// If this is a tuple of ints, a reduction is performed on multiple
        /// axes, instead of a single axis or all the axes as before.
        /// </param>
        /// <param name="@out">
        /// Alternate output array in which to place the result.  It must have
        /// the same shape as the expected output and its type is preserved
        /// (e.g., if it is of type float, then it will remain so, returning
        /// 1.0 for True and 0.0 for False, regardless of the type of a).
        /// See doc.ufuncs (Section “Output arguments”) for details.
        /// </param>
        /// <param name="keepdims">
        /// If this is set to True, the axes which are reduced are left
        /// in the result as dimensions with size one. With this option,
        /// the result will broadcast correctly against the input array.
        /// 
        /// If the default value is passed, then keepdims will not be
        /// passed through to the any method of sub-classes of
        /// ndarray, however any non-default value will be.  If the
        /// sub-class’ method does not implement keepdims any
        /// exceptions will be raised.
        /// </param>
        /// <returns>
        /// A new boolean or ndarray is returned unless out is specified,
        /// in which case a reference to out is returned.
        /// </returns>
        public static NDarray<bool> any(NDarray a, int[] axis, NDarray @out = null, bool? keepdims = null)
            => NumPy.Instance.any(a, axis:axis, @out:@out, keepdims:keepdims);
        
        /// <summary>
        /// Test whether any array element along a given axis evaluates to True.
        /// 
        /// Returns single boolean unless axis is not None
        /// 
        /// Notes
        /// 
        /// Not a Number (NaN), positive infinity and negative infinity evaluate
        /// to True because these are not equal to zero.
        /// </summary>
        /// <param name="a">
        /// Input array or object that can be converted to an array.
        /// </param>
        /// <returns>
        /// A new boolean or ndarray is returned unless out is specified,
        /// in which case a reference to out is returned.
        /// </returns>
        public static bool any(NDarray a)
            => NumPy.Instance.any(a);
        
        /// <summary>
        /// Test element-wise for negative infinity, return result as bool array.
        /// 
        /// Notes
        /// 
        /// NumPy uses the IEEE Standard for Binary Floating-Point for Arithmetic
        /// (IEEE 754).
        /// 
        /// Errors result if the second argument is also supplied when x is a scalar
        /// input, if first and second arguments have different shapes, or if the
        /// first argument has complex values.
        /// </summary>
        /// <param name="x">
        /// The input array.
        /// </param>
        /// <param name="@out">
        /// A boolean array with the same shape and type as x to store the
        /// result.
        /// </param>
        /// <returns>
        /// A boolean array with the same dimensions as the input.
        /// If second argument is not supplied then a numpy boolean array is
        /// returned with values True where the corresponding element of the
        /// input is negative infinity and values False where the element of
        /// the input is not negative infinity.
        /// 
        /// If a second argument is supplied the result is stored there. If the
        /// type of that array is a numeric type the result is represented as
        /// zeros and ones, if the type is boolean then as False and True. The
        /// return value out is then a reference to that array.
        /// </returns>
        public static NDarray isneginf(NDarray x, NDarray @out = null)
            => NumPy.Instance.isneginf(x, @out:@out);
        
        /// <summary>
        /// Test element-wise for positive infinity, return result as bool array.
        /// 
        /// Notes
        /// 
        /// NumPy uses the IEEE Standard for Binary Floating-Point for Arithmetic
        /// (IEEE 754).
        /// 
        /// Errors result if the second argument is also supplied when x is a scalar
        /// input, if first and second arguments have different shapes, or if the
        /// first argument has complex values
        /// </summary>
        /// <param name="x">
        /// The input array.
        /// </param>
        /// <param name="y">
        /// A boolean array with the same shape as x to store the result.
        /// </param>
        /// <returns>
        /// A boolean array with the same dimensions as the input.
        /// If second argument is not supplied then a boolean array is returned
        /// with values True where the corresponding element of the input is
        /// positive infinity and values False where the element of the input is
        /// not positive infinity.
        /// 
        /// If a second argument is supplied the result is stored there. If the
        /// type of that array is a numeric type the result is represented as zeros
        /// and ones, if the type is boolean then as False and True.
        /// The return value out is then a reference to that array.
        /// </returns>
        public static NDarray isposinf(NDarray x, NDarray y = null)
            => NumPy.Instance.isposinf(x, y:y);
        
        /// <summary>
        /// Returns a bool array, where True if input element is complex.
        /// 
        /// What is tested is whether the input has a non-zero imaginary part, not if
        /// the input type is complex.
        /// </summary>
        /// <param name="x">
        /// Input array.
        /// </param>
        /// <returns>
        /// Output array.
        /// </returns>
        public static NDarray iscomplex(NDarray x)
            => NumPy.Instance.iscomplex(x);
        
        /// <summary>
        /// Check for a complex type or an array of complex numbers.
        /// 
        /// The type of the input is checked, not the value. Even if the input
        /// has an imaginary part equal to zero, iscomplexobj evaluates to True.
        /// </summary>
        /// <param name="x">
        /// The input can be of any type and shape.
        /// </param>
        /// <returns>
        /// The return value, True if x is of a complex type or has at least
        /// one complex element.
        /// </returns>
        public static bool iscomplexobj(object x)
            => NumPy.Instance.iscomplexobj(x);
        
        /// <summary>
        /// Returns True if the array is Fortran contiguous but not C contiguous.
        /// 
        /// This function is obsolete and, because of changes due to relaxed stride
        /// checking, its return value for the same array may differ for versions
        /// of NumPy &gt;= 1.10.0 and previous versions. If you only want to check if an
        /// array is Fortran contiguous use a.flags.f_contiguous instead.
        /// </summary>
        /// <param name="a">
        /// Input array.
        /// </param>
        public static bool isfortran(NDarray a)
            => NumPy.Instance.isfortran(a);
        
        /// <summary>
        /// Returns a bool array, where True if input element is real.
        /// 
        /// If element has complex type with zero complex part, the return value
        /// for that element is True.
        /// </summary>
        /// <param name="x">
        /// Input array.
        /// </param>
        /// <returns>
        /// Boolean array of same shape as x.
        /// </returns>
        public static NDarray isreal(NDarray x)
            => NumPy.Instance.isreal(x);
        
        /// <summary>
        /// Return True if x is a not complex type or an array of complex numbers.
        /// 
        /// The type of the input is checked, not the value. So even if the input
        /// has an imaginary part equal to zero, isrealobj evaluates to False
        /// if the data type is complex.
        /// </summary>
        /// <param name="x">
        /// The input can be of any type and shape.
        /// </param>
        /// <returns>
        /// The return value, False if x is of a complex type.
        /// </returns>
        public static bool isrealobj(object x)
            => NumPy.Instance.isrealobj(x);
        
        /// <summary>
        /// Returns True if the type of num is a scalar type.
        /// 
        /// Notes
        /// 
        /// In almost all cases np.ndim(x) == 0 should be used instead of this
        /// function, as that will also return true for 0d arrays. This is how
        /// numpy overloads functions in the style of the dx arguments to gradient
        /// and the bins argument to histogram. Some key differences:
        /// </summary>
        /// <param name="num">
        /// Input argument, can be of any type and shape.
        /// </param>
        /// <returns>
        /// True if num is a scalar type, False if it is not.
        /// </returns>
        public static bool isscalar(object num)
            => NumPy.Instance.isscalar(num);
        
        /// <summary>
        /// Returns True if two arrays are element-wise equal within a tolerance.
        /// 
        /// The tolerance values are positive, typically very small numbers.  The
        /// relative difference (rtol * abs(b)) and the absolute difference
        /// atol are added together to compare against the absolute difference
        /// between a and b.
        /// 
        /// If either array contains one or more NaNs, False is returned.
        /// Infs are treated as equal if they are in the same place and of the same
        /// sign in both arrays.
        /// 
        /// Notes
        /// 
        /// If the following equation is element-wise True, then allclose returns
        /// True.
        /// 
        /// The above equation is not symmetric in a and b, so that
        /// allclose(a, b) might be different from allclose(b, a) in
        /// some rare cases.
        /// 
        /// The comparison of a and b uses standard broadcasting, which
        /// means that a and b need not have the same shape in order for
        /// allclose(a, b) to evaluate to True.  The same is true for
        /// equal but not array_equal.
        /// </summary>
        /// <param name="b">
        /// Input arrays to compare.
        /// </param>
        /// <param name="a">
        /// Input arrays to compare.
        /// </param>
        /// <param name="rtol">
        /// The relative tolerance parameter (see Notes).
        /// </param>
        /// <param name="atol">
        /// The absolute tolerance parameter (see Notes).
        /// </param>
        /// <param name="equal_nan">
        /// Whether to compare NaN’s as equal.  If True, NaN’s in a will be
        /// considered equal to NaN’s in b in the output array.
        /// </param>
        /// <returns>
        /// Returns True if the two arrays are equal within the given
        /// tolerance; False otherwise.
        /// </returns>
        public static bool allclose(NDarray b, NDarray a, float rtol, float atol, bool equal_nan)
            => NumPy.Instance.allclose(b, a, rtol, atol, equal_nan);
        
        /// <summary>
        /// Returns a boolean array where two arrays are element-wise equal within a
        /// tolerance.
        /// 
        /// The tolerance values are positive, typically very small numbers.  The
        /// relative difference (rtol * abs(b)) and the absolute difference
        /// atol are added together to compare against the absolute difference
        /// between a and b.
        /// 
        /// Notes
        /// 
        /// For finite values, isclose uses the following equation to test whether
        /// two floating point values are equivalent.
        /// 
        /// Unlike the built-in math.isclose, the above equation is not symmetric
        /// in a and b – it assumes b is the reference value – so that
        /// isclose(a, b) might be different from isclose(b, a). Furthermore,
        /// the default value of atol is not zero, and is used to determine what
        /// small values should be considered close to zero. The default value is
        /// appropriate for expected values of order unity: if the expected values
        /// are significantly smaller than one, it can result in false positives.
        /// atol should be carefully selected for the use case at hand. A zero value
        /// for atol will result in False if either a or b is zero.
        /// </summary>
        /// <param name="b">
        /// Input arrays to compare.
        /// </param>
        /// <param name="a">
        /// Input arrays to compare.
        /// </param>
        /// <param name="rtol">
        /// The relative tolerance parameter (see Notes).
        /// </param>
        /// <param name="atol">
        /// The absolute tolerance parameter (see Notes).
        /// </param>
        /// <param name="equal_nan">
        /// Whether to compare NaN’s as equal.  If True, NaN’s in a will be
        /// considered equal to NaN’s in b in the output array.
        /// </param>
        /// <returns>
        /// Returns a boolean array of where a and b are equal within the
        /// given tolerance. If both a and b are scalars, returns a single
        /// boolean value.
        /// </returns>
        public static NDarray isclose(NDarray b, NDarray a, float rtol, float atol, bool equal_nan)
            => NumPy.Instance.isclose(b, a, rtol, atol, equal_nan);
        
        /// <summary>
        /// True if two arrays have the same shape and elements, False otherwise.
        /// </summary>
        /// <param name="a2">
        /// Input arrays.
        /// </param>
        /// <param name="a1">
        /// Input arrays.
        /// </param>
        /// <returns>
        /// Returns True if the arrays are equal.
        /// </returns>
        public static bool array_equal(NDarray a2, NDarray a1)
            => NumPy.Instance.array_equal(a2, a1);
        
        /// <summary>
        /// Returns True if input arrays are shape consistent and all elements equal.
        /// 
        /// Shape consistent means they are either the same shape, or one input array
        /// can be broadcasted to create the same shape as the other one.
        /// </summary>
        /// <param name="a2">
        /// Input arrays.
        /// </param>
        /// <param name="a1">
        /// Input arrays.
        /// </param>
        /// <returns>
        /// True if equivalent, False otherwise.
        /// </returns>
        public static bool array_equiv(NDarray a2, NDarray a1)
            => NumPy.Instance.array_equiv(a2, a1);
        
        
    }
}
