using System;

namespace Memorize.Items
{
    ///<summary>
    /// This class is meant to be to an abstract class
    /// for memos and lists of memos and implement the
    /// design of a composite pattern. This entails that
    /// any component that implements this, can be an item 
    /// (Leaf) which has no children and only stores data.
    /// A component can also be a composite, which contains
    /// a list of elements.
    ///</summary>
    public abstract class MemoComponent  
    {
        protected string _title;
        /* Memo list methods */
        public virtual void Add(MemoComponent mc) 
        {
            throw new System.InvalidOperationException(
                    "Add() not implemented for this class");
        }
        public virtual void Remove(MemoComponent mc) 
        {
            throw new System.InvalidOperationException(
                    "Remove() not implemented for this class");
        }
        public virtual MemoComponent GetChild(int i) 
        {
            throw new System.InvalidOperationException(
                    "GetChild() not implemented for this class");
        }
        public virtual bool Contains(MemoComponent mc)
        {
            throw new System.InvalidOperationException(
                    "Contains() not implemented for this class");
        }

        // Both item and composite have a title!
        public virtual string GetTitle()
        {
            return this._title;
        }

        public virtual void Clear()
        {
            throw new System.InvalidOperationException(
                    "Clear() not implemented for this class");
        }

        public virtual void SetTitle(string s)
        {
            this._title = s;
        }

        /* MemoItem methods come here */
        public virtual string GetContent()
        {
            throw new System.InvalidOperationException(
                    "GetContent() not implemented for this class");
        }

        public virtual void SetContent(string s)
        {
            throw new System.InvalidOperationException(
                    "SetContent() not implemented for this class");
        }

        public virtual void AddAttribute(Attribute a)
        {
            throw new System.InvalidOperationException(
                    "AddAttribute() not implemented for this class");
        }
        
    }
}
