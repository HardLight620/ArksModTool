INCLUDE <ASMInclude.asm>

public CommInit
public CommInit_End
public CommInit_Bindings

.DATA

CommInit_Bindings	DWORD		0
bind0				DWORD		b0+1
bind1				DWORD		b1+1
bind2				DWORD		b2+1

.CODE

CommInit:
	push ebx
	push esi
	push edi
b0:	mov esi, NO_ADDRESS
	mov edi, [esi+1C]
	mov esi, [esi+18]
	cmp [esi], 00
	jne d0
	xor ebx, ebx
l0:
b1:	mov edx, NO_ADDRESS
b2:	mov eax, ds:[NO_ADDRESS]
	push [esi+ebx*4+40]
	push eax
	call dword ptr [edx]			; GetProcAddress
	test eax, eax
	je d2
	mov [esi+ebx*4], eax
	inc ebx
	cmp ebx, 9
	jb l0
d0:	test edi, edi
	je d1
	mov eax, [edi+38]
	test eax, eax
	jne d1
	push 00
	push 00
	push 03
	push 00
	push 00
	push 0C0000000
	push edi
	call dword ptr[esi+10]			; CreateFileA
	cmp eax, s32 0FFFFFFFF
	je d1
	mov [edi+38], eax
	push 02
	mov ecx, esp
	push 00
	push 00
	push ecx
	push eax
	call dword ptr [esi+14]			; SetNamedPipeHandleState
	add esp, 04
d1: xor eax, eax
	jmp d3
d2:	mov eax, 00000001
d3: pop edi
	pop esi
	pop ebx
	ret
CommInit_End:

END