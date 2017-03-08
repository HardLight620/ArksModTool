INCLUDE <ASMInclude.asm>

public DisableAutoShowLog
public DisableAutoShowLog_End
public DisableAutoShowLog_Bindings

.DATA

DisableAutoShowLog_Bindings	DWORD		0
bind0						DWORD		b0+2
bind1						DWORD		b1+2
bind2						DWORD		b2+1

.CODE

DisableAutoShowLog:
	push ebx
	mov ebx, ecx
b0:	add ebx, NO_ADDRESS
	cmp dword ptr[ebx], 00
	jne d1
b1:	mov ecx, ds:[NO_ADDRESS]
	test ecx, ecx
	je d0
	mov eax, [ecx+04]
	cmp dword ptr[eax+000002BC], 02
	je d1
	push 01
b2:	call NO_SYMBOL
d0: or dword ptr[ebx], 02
d1: pop ebx
	ret
DisableAutoShowLog_End:

END