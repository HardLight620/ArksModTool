INCLUDE <ASMInclude.asm>

public Camera2TransOverride
public Camera2TransOverride_End
public Camera2TransOverride_Bindings

.DATA

Camera2TransOverride_Bindings	DWORD		0
bind0							DWORD		b0+1
bind1							DWORD		b1+1

.CODE

Camera2TransOverride:
	mov ebx, 00000001
	test eax, eax
	je d0
	mov ecx, eax
b0:	call NO_SYMBOL				; Camera2Override
	add eax, 20
	push eax
	lea ecx, [esp+000000C4]
	xor eax, eax
	mov [ecx], eax
b1:	call NO_SYMBOL
	jmp d1
	xor ebx, ebx
d0:	mov dword ptr [esp+000000C0], 00000000
d1:
Camera2TransOverride_End:

END