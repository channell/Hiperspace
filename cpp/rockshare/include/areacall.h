#include <google/protobuf/arena.h>

static google::protobuf::Arena arena;
		void* __stdcall operator new (size_t size)
{
	return arena.AllocateAligned(size);
}
void* __cdecl operator new (size_t size)
{
	return ::operator new(size);
}
		void __stdcall operator delete (void* p)
{
}
		void __stdcall operator delete[] (void* p)
{
}
