INCLUDE <ASMInclude.asm>

.CODE

DllMain PROC STDCALL hInstDLL:DWORD, fdwReason:DWORD, lpvReserved:DWORD 
	mov eax, 1
	ret
DllMain ENDP

END