// ---------------------------------------------------------------------------------------
//                                   Hiperspace
//                        Copyright (c) 2023 Cepheis Ltd
//                                    www.cepheis.com
//
// This file is part of Hiperspace and is distributed under the GPL Open Source License. 
// ---------------------------------------------------------------------------------------
namespace Hiperspace
{
    public class Transaction : IDisposable
    {
        private HiperSpace _space;
        public Transaction(HiperSpace space) 
        { 
            _space = space;
        }

        public void Dispose()
        {
            _space.EndTransaction();
        }
    }
}
