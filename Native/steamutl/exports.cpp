#include "MiniUTL/utlvector.h"
#include "MiniUTL/utlbuffer.h"

extern "C" CUtlBuffer *CUtlBuffer_Create(int growSize, int initialSize, int nFlags) {
    return new CUtlBuffer(growSize, initialSize, nFlags);
}

extern "C" void CUtlBuffer_Delete(CUtlBuffer *buf) {
    delete buf;
}