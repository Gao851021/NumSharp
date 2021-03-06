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
    public partial class NumPy
    {
        
        /// <summary>
        /// Return a sorted copy of an array.
        /// 
        /// Notes
        /// 
        /// The various sorting algorithms are characterized by their average speed,
        /// worst case performance, work space size, and whether they are stable. A
        /// stable sort keeps items with the same key in the same relative
        /// order. The three available algorithms have the following
        /// properties:
        /// 
        /// All the sort algorithms make temporary copies of the data when
        /// sorting along any but the last axis.  Consequently, sorting along
        /// the last axis is faster and uses less space than sorting along
        /// any other axis.
        /// 
        /// The sort order for complex numbers is lexicographic. If both the real
        /// and imaginary parts are non-nan then the order is determined by the
        /// real parts except when they are equal, in which case the order is
        /// determined by the imaginary parts.
        /// 
        /// Previous to numpy 1.4.0 sorting real and complex arrays containing nan
        /// values led to undefined behaviour. In numpy versions &gt;= 1.4.0 nan
        /// values are sorted to the end. The extended sort order is:
        /// 
        /// where R is a non-nan real value. Complex values with the same nan
        /// placements are sorted according to the non-nan part if it exists.
        /// Non-nan values are sorted as before.
        /// 
        /// quicksort has been changed to an introsort which will switch
        /// heapsort when it does not make enough progress. This makes its
        /// worst case O(n*log(n)).
        /// 
        /// ‘stable’ automatically choses the best stable sorting algorithm
        /// for the data type being sorted. It is currently mapped to
        /// merge sort.
        /// </summary>
        /// <param name="a">
        /// Array to be sorted.
        /// </param>
        /// <param name="axis">
        /// Axis along which to sort. If None, the array is flattened before
        /// sorting. The default is -1, which sorts along the last axis.
        /// </param>
        /// <param name="kind">
        /// Sorting algorithm. Default is ‘quicksort’.
        /// </param>
        /// <param name="order">
        /// When a is an array with fields defined, this argument specifies
        /// which fields to compare first, second, etc.  A single field can
        /// be specified as a string, and not all fields need be specified,
        /// but unspecified fields will still be used, in the order in which
        /// they come up in the dtype, to break ties.
        /// </param>
        /// <returns>
        /// Array of the same type and shape as a.
        /// </returns>
        public NDarray sort(NDarray a, int? axis = -1, string kind = null, string order = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            if (axis!=-1) kwargs["axis"]=ToPython(axis);
            if (kind!=null) kwargs["kind"]=ToPython(kind);
            if (order!=null) kwargs["order"]=ToPython(order);
            dynamic py = __self__.InvokeMethod("sort", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Perform an indirect stable sort using a sequence of keys.
        /// 
        /// Given multiple sorting keys, which can be interpreted as columns in a
        /// spreadsheet, lexsort returns an array of integer indices that describes
        /// the sort order by multiple columns. The last key in the sequence is used
        /// for the primary sort order, the second-to-last key for the secondary sort
        /// order, and so on. The keys argument must be a sequence of objects that
        /// can be converted to arrays of the same shape. If a 2D array is provided
        /// for the keys argument, it’s rows are interpreted as the sorting keys and
        /// sorting is according to the last row, second last row etc.
        /// </summary>
        /// <param name="keys">
        /// The k different “columns” to be sorted.  The last column (or row if
        /// keys is a 2D array) is the primary sort key.
        /// </param>
        /// <param name="axis">
        /// Axis to be indirectly sorted.  By default, sort over the last axis.
        /// </param>
        /// <returns>
        /// Array of indices that sort the keys along the specified axis.
        /// </returns>
        public NDarray lexsort(NDarray keys, int? axis = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                keys,
            });
            var kwargs=new PyDict();
            if (axis!=null) kwargs["axis"]=ToPython(axis);
            dynamic py = __self__.InvokeMethod("lexsort", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Returns the indices that would sort an array.
        /// 
        /// Perform an indirect sort along the given axis using the algorithm specified
        /// by the kind keyword. It returns an array of indices of the same shape as
        /// a that index data along the given axis in sorted order.
        /// 
        /// Notes
        /// 
        /// See sort for notes on the different sorting algorithms.
        /// 
        /// As of NumPy 1.4.0 argsort works with real/complex arrays containing
        /// nan values. The enhanced sort order is documented in sort.
        /// </summary>
        /// <param name="a">
        /// Array to sort.
        /// </param>
        /// <param name="axis">
        /// Axis along which to sort.  The default is -1 (the last axis). If None,
        /// the flattened array is used.
        /// </param>
        /// <param name="kind">
        /// Sorting algorithm.
        /// </param>
        /// <param name="order">
        /// When a is an array with fields defined, this argument specifies
        /// which fields to compare first, second, etc.  A single field can
        /// be specified as a string, and not all fields need be specified,
        /// but unspecified fields will still be used, in the order in which
        /// they come up in the dtype, to break ties.
        /// </param>
        /// <returns>
        /// Array of indices that sort a along the specified axis.
        /// If a is one-dimensional, a[index_array] yields a sorted a.
        /// More generally, np.take_along_axis(a, index_array, axis=a) always
        /// yields the sorted a, irrespective of dimensionality.
        /// </returns>
        public NDarray argsort(NDarray a, int? axis = null, string kind = null, string order = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            if (axis!=null) kwargs["axis"]=ToPython(axis);
            if (kind!=null) kwargs["kind"]=ToPython(kind);
            if (order!=null) kwargs["order"]=ToPython(order);
            dynamic py = __self__.InvokeMethod("argsort", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return a copy of an array sorted along the first axis.
        /// 
        /// Notes
        /// 
        /// np.msort(a) is equivalent to  np.sort(a, axis=0).
        /// </summary>
        /// <param name="a">
        /// Array to be sorted.
        /// </param>
        /// <returns>
        /// Array of the same type and shape as a.
        /// </returns>
        public NDarray msort(NDarray a)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("msort", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Sort a complex array using the real part first, then the imaginary part.
        /// </summary>
        /// <param name="a">
        /// Input array
        /// </param>
        /// <returns>
        /// Always returns a sorted complex array.
        /// </returns>
        public NDarray sort_complex(NDarray a)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("sort_complex", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return a partitioned copy of an array.
        /// 
        /// Creates a copy of the array with its elements rearranged in such a
        /// way that the value of the element in k-th position is in the
        /// position it would be in a sorted array. All elements smaller than
        /// the k-th element are moved before this element and all equal or
        /// greater are moved behind it. The ordering of the elements in the two
        /// partitions is undefined.
        /// 
        /// Notes
        /// 
        /// The various selection algorithms are characterized by their average
        /// speed, worst case performance, work space size, and whether they are
        /// stable. A stable sort keeps items with the same key in the same
        /// relative order. The available algorithms have the following
        /// properties:
        /// 
        /// All the partition algorithms make temporary copies of the data when
        /// partitioning along any but the last axis.  Consequently,
        /// partitioning along the last axis is faster and uses less space than
        /// partitioning along any other axis.
        /// 
        /// The sort order for complex numbers is lexicographic. If both the
        /// real and imaginary parts are non-nan then the order is determined by
        /// the real parts except when they are equal, in which case the order
        /// is determined by the imaginary parts.
        /// </summary>
        /// <param name="a">
        /// Array to be sorted.
        /// </param>
        /// <param name="kth">
        /// Element index to partition by. The k-th value of the element
        /// will be in its final sorted position and all smaller elements
        /// will be moved before it and all equal or greater elements behind
        /// it. The order of all elements in the partitions is undefined. If
        /// provided with a sequence of k-th it will partition all elements
        /// indexed by k-th  of them into their sorted position at once.
        /// </param>
        /// <param name="axis">
        /// Axis along which to sort. If None, the array is flattened before
        /// sorting. The default is -1, which sorts along the last axis.
        /// </param>
        /// <param name="kind">
        /// Selection algorithm. Default is ‘introselect’.
        /// </param>
        /// <param name="order">
        /// When a is an array with fields defined, this argument
        /// specifies which fields to compare first, second, etc.  A single
        /// field can be specified as a string.  Not all fields need be
        /// specified, but unspecified fields will still be used, in the
        /// order in which they come up in the dtype, to break ties.
        /// </param>
        /// <returns>
        /// Array of the same type and shape as a.
        /// </returns>
        public NDarray partition(NDarray a, int[] kth, int? axis = null, string kind = null, string order = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                a,
                kth,
            });
            var kwargs=new PyDict();
            if (axis!=null) kwargs["axis"]=ToPython(axis);
            if (kind!=null) kwargs["kind"]=ToPython(kind);
            if (order!=null) kwargs["order"]=ToPython(order);
            dynamic py = __self__.InvokeMethod("partition", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Perform an indirect partition along the given axis using the
        /// algorithm specified by the kind keyword. It returns an array of
        /// indices of the same shape as a that index data along the given
        /// axis in partitioned order.
        /// 
        /// Notes
        /// 
        /// See partition for notes on the different selection algorithms.
        /// </summary>
        /// <param name="a">
        /// Array to sort.
        /// </param>
        /// <param name="kth">
        /// Element index to partition by. The k-th element will be in its
        /// final sorted position and all smaller elements will be moved
        /// before it and all larger elements behind it. The order all
        /// elements in the partitions is undefined. If provided with a
        /// sequence of k-th it will partition all of them into their sorted
        /// position at once.
        /// </param>
        /// <param name="axis">
        /// Axis along which to sort. The default is -1 (the last axis). If
        /// None, the flattened array is used.
        /// </param>
        /// <param name="kind">
        /// Selection algorithm. Default is ‘introselect’
        /// </param>
        /// <param name="order">
        /// When a is an array with fields defined, this argument
        /// specifies which fields to compare first, second, etc. A single
        /// field can be specified as a string, and not all fields need be
        /// specified, but unspecified fields will still be used, in the
        /// order in which they come up in the dtype, to break ties.
        /// </param>
        /// <returns>
        /// Array of indices that partition a along the specified axis.
        /// If a is one-dimensional, a[index_array] yields a partitioned a.
        /// More generally, np.take_along_axis(a, index_array, axis=a) always
        /// yields the partitioned a, irrespective of dimensionality.
        /// </returns>
        public NDarray argpartition(NDarray a, int[] kth, int? axis = null, string kind = null, string order = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                a,
                kth,
            });
            var kwargs=new PyDict();
            if (axis!=null) kwargs["axis"]=ToPython(axis);
            if (kind!=null) kwargs["kind"]=ToPython(kind);
            if (order!=null) kwargs["order"]=ToPython(order);
            dynamic py = __self__.InvokeMethod("argpartition", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Returns the indices of the maximum values along an axis.
        /// 
        /// Notes
        /// 
        /// In case of multiple occurrences of the maximum values, the indices
        /// corresponding to the first occurrence are returned.
        /// </summary>
        /// <param name="a">
        /// Input array.
        /// </param>
        /// <param name="axis">
        /// By default, the index is into the flattened array, otherwise
        /// along the specified axis.
        /// </param>
        /// <param name="@out">
        /// If provided, the result will be inserted into this array. It should
        /// be of the appropriate shape and dtype.
        /// </param>
        /// <returns>
        /// Array of indices into the array. It has the same shape as a.shape
        /// with the dimension along axis removed.
        /// </returns>
        public NDarray argmax(NDarray a, int? axis = null, NDarray @out = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            if (axis!=null) kwargs["axis"]=ToPython(axis);
            if (@out!=null) kwargs["out"]=ToPython(@out);
            dynamic py = __self__.InvokeMethod("argmax", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return the indices of the maximum values in the specified axis ignoring
        /// NaNs. For all-NaN slices ValueError is raised. Warning: the
        /// results cannot be trusted if a slice contains only NaNs and -Infs.
        /// </summary>
        /// <param name="a">
        /// Input data.
        /// </param>
        /// <param name="axis">
        /// Axis along which to operate.  By default flattened input is used.
        /// </param>
        /// <returns>
        /// An array of indices or a single index value.
        /// </returns>
        public NDarray nanargmax(NDarray a, int? axis = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            if (axis!=null) kwargs["axis"]=ToPython(axis);
            dynamic py = __self__.InvokeMethod("nanargmax", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Returns the indices of the minimum values along an axis.
        /// 
        /// Notes
        /// 
        /// In case of multiple occurrences of the minimum values, the indices
        /// corresponding to the first occurrence are returned.
        /// </summary>
        /// <param name="a">
        /// Input array.
        /// </param>
        /// <param name="axis">
        /// By default, the index is into the flattened array, otherwise
        /// along the specified axis.
        /// </param>
        /// <param name="@out">
        /// If provided, the result will be inserted into this array. It should
        /// be of the appropriate shape and dtype.
        /// </param>
        /// <returns>
        /// Array of indices into the array. It has the same shape as a.shape
        /// with the dimension along axis removed.
        /// </returns>
        public NDarray argmin(NDarray a, int? axis = null, NDarray @out = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            if (axis!=null) kwargs["axis"]=ToPython(axis);
            if (@out!=null) kwargs["out"]=ToPython(@out);
            dynamic py = __self__.InvokeMethod("argmin", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return the indices of the minimum values in the specified axis ignoring
        /// NaNs. For all-NaN slices ValueError is raised. Warning: the results
        /// cannot be trusted if a slice contains only NaNs and Infs.
        /// </summary>
        /// <param name="a">
        /// Input data.
        /// </param>
        /// <param name="axis">
        /// Axis along which to operate.  By default flattened input is used.
        /// </param>
        /// <returns>
        /// An array of indices or a single index value.
        /// </returns>
        public NDarray nanargmin(NDarray a, int? axis = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            if (axis!=null) kwargs["axis"]=ToPython(axis);
            dynamic py = __self__.InvokeMethod("nanargmin", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Find the indices of array elements that are non-zero, grouped by element.
        /// 
        /// Notes
        /// 
        /// np.argwhere(a) is the same as np.transpose(np.nonzero(a)).
        /// 
        /// The output of argwhere is not suitable for indexing arrays.
        /// For this purpose use nonzero(a) instead.
        /// </summary>
        /// <param name="a">
        /// Input data.
        /// </param>
        /// <returns>
        /// Indices of elements that are non-zero. Indices are grouped by element.
        /// </returns>
        public NDarray argwhere(NDarray a)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("argwhere", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return the indices of the elements that are non-zero.
        /// 
        /// Returns a tuple of arrays, one for each dimension of a,
        /// containing the indices of the non-zero elements in that
        /// dimension. The values in a are always tested and returned in
        /// row-major, C-style order. The corresponding non-zero
        /// values can be obtained with:
        /// 
        /// To group the indices by element, rather than dimension, use:
        /// 
        /// The result of this is always a 2-D array, with a row for
        /// each non-zero element.
        /// </summary>
        /// <param name="a">
        /// Input array.
        /// </param>
        /// <returns>
        /// Indices of elements that are non-zero.
        /// </returns>
        public NDarray[] nonzero(NDarray a)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("nonzero", pyargs, kwargs);
            return ToCsharp<NDarray[]>(py);
        }
        
        /// <summary>
        /// Return indices that are non-zero in the flattened version of a.
        /// 
        /// This is equivalent to np.nonzero(np.ravel(a))[0].
        /// </summary>
        /// <param name="a">
        /// Input data.
        /// </param>
        /// <returns>
        /// Output array, containing the indices of the elements of a.ravel()
        /// that are non-zero.
        /// </returns>
        public NDarray flatnonzero(NDarray a)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("flatnonzero", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Return elements chosen from x or y depending on condition.
        /// 
        /// Notes
        /// 
        /// If all the arrays are 1-D, where is equivalent to:
        /// </summary>
        /// <param name="condition">
        /// Where True, yield x, otherwise yield y.
        /// </param>
        /// <param name="y">
        /// Values from which to choose. x, y and condition need to be
        /// broadcastable to some shape.
        /// </param>
        /// <param name="x">
        /// Values from which to choose. x, y and condition need to be
        /// broadcastable to some shape.
        /// </param>
        /// <returns>
        /// An array with elements from x where condition is True, and elements
        /// from y elsewhere.
        /// </returns>
        public NDarray @where(NDarray condition, NDarray y, NDarray x)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                condition,
                y,
                x,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("where", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Find indices where elements should be inserted to maintain order.
        /// 
        /// Find the indices into a sorted array a such that, if the
        /// corresponding elements in v were inserted before the indices, the
        /// order of a would be preserved.
        /// 
        /// Assuming that a is sorted:
        /// 
        /// Notes
        /// 
        /// Binary search is used to find the required insertion points.
        /// 
        /// As of NumPy 1.4.0 searchsorted works with real/complex arrays containing
        /// nan values. The enhanced sort order is documented in sort.
        /// 
        /// This function is a faster version of the builtin python bisect.bisect_left
        /// (side='left') and bisect.bisect_right (side='right') functions,
        /// which is also vectorized in the v argument.
        /// </summary>
        /// <param name="a">
        /// Input array. If sorter is None, then it must be sorted in
        /// ascending order, otherwise sorter must be an array of indices
        /// that sort it.
        /// </param>
        /// <param name="v">
        /// Values to insert into a.
        /// </param>
        /// <param name="side">
        /// If ‘left’, the index of the first suitable location found is given.
        /// If ‘right’, return the last such index.  If there is no suitable
        /// index, return either 0 or N (where N is the length of a).
        /// </param>
        /// <param name="sorter">
        /// Optional array of integer indices that sort array a into ascending
        /// order. They are typically the result of argsort.
        /// </param>
        /// <returns>
        /// Array of insertion points with the same shape as v.
        /// </returns>
        public NDarray<int> searchsorted(NDarray a, NDarray v, string side = null, NDarray sorter = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                a,
                v,
            });
            var kwargs=new PyDict();
            if (side!=null) kwargs["side"]=ToPython(side);
            if (sorter!=null) kwargs["sorter"]=ToPython(sorter);
            dynamic py = __self__.InvokeMethod("searchsorted", pyargs, kwargs);
            return ToCsharp<NDarray<int>>(py);
        }
        
        /// <summary>
        /// Return the elements of an array that satisfy some condition.
        /// 
        /// This is equivalent to np.compress(ravel(condition), ravel(arr)).  If
        /// condition is boolean np.extract is equivalent to arr[condition].
        /// 
        /// Note that place does the exact opposite of extract.
        /// </summary>
        /// <param name="condition">
        /// An array whose nonzero or True entries indicate the elements of arr
        /// to extract.
        /// </param>
        /// <param name="arr">
        /// Input array of the same size as condition.
        /// </param>
        /// <returns>
        /// Rank 1 array of values from arr where condition is True.
        /// </returns>
        public NDarray extract(NDarray condition, NDarray arr)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                condition,
                arr,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("extract", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        /// <summary>
        /// Counts the number of non-zero values in the array a.
        /// 
        /// The word “non-zero” is in reference to the Python 2.x
        /// built-in method __nonzero__() (renamed __bool__()
        /// in Python 3.x) of Python objects that tests an object’s
        /// “truthfulness”. For example, any number is considered
        /// truthful if it is nonzero, whereas any string is considered
        /// truthful if it is not the empty string. Thus, this function
        /// (recursively) counts how many elements in a (and in
        /// sub-arrays thereof) have their __nonzero__() or __bool__()
        /// method evaluated to True.
        /// </summary>
        /// <param name="a">
        /// The array for which to count non-zeros.
        /// </param>
        /// <param name="axis">
        /// Axis or tuple of axes along which to count non-zeros.
        /// Default is None, meaning that non-zeros will be counted
        /// along a flattened version of a.
        /// </param>
        /// <returns>
        /// Number of non-zero values in the array along a given axis.
        /// Otherwise, the total number of non-zero values in the array
        /// is returned.
        /// </returns>
        public NDarray<int> count_nonzero(NDarray a, int[] axis)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            if (axis!=null) kwargs["axis"]=ToPython(axis);
            dynamic py = __self__.InvokeMethod("count_nonzero", pyargs, kwargs);
            return ToCsharp<NDarray<int>>(py);
        }
        
        /// <summary>
        /// Counts the number of non-zero values in the array a.
        /// 
        /// The word “non-zero” is in reference to the Python 2.x
        /// built-in method __nonzero__() (renamed __bool__()
        /// in Python 3.x) of Python objects that tests an object’s
        /// “truthfulness”. For example, any number is considered
        /// truthful if it is nonzero, whereas any string is considered
        /// truthful if it is not the empty string. Thus, this function
        /// (recursively) counts how many elements in a (and in
        /// sub-arrays thereof) have their __nonzero__() or __bool__()
        /// method evaluated to True.
        /// </summary>
        /// <param name="a">
        /// The array for which to count non-zeros.
        /// </param>
        /// <returns>
        /// Number of non-zero values in the array along a given axis.
        /// Otherwise, the total number of non-zero values in the array
        /// is returned.
        /// </returns>
        public int count_nonzero(NDarray a)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                a,
            });
            var kwargs=new PyDict();
            dynamic py = __self__.InvokeMethod("count_nonzero", pyargs, kwargs);
            return ToCsharp<int>(py);
        }
        
    }
}
