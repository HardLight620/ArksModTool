INCLUDE <ASMInclude.asm>

public CameraControlMain
public CameraControlMain_End
public CameraControlMain_Bindings

.DATA

CameraControlMain_Bindings	DWORD		0
bind0						DWORD		b0+2
bind1						DWORD		b1+1
bind2						DWORD		b2+1
bind3						DWORD		b3+1

.CODE

CameraControlMain:
	push ebp
	push edi
	push esi
	push ebx
b0:	mov ecx, ds:[NO_ADDRESS]
	test ecx, ecx
	je d2
b1:	call NO_SYMBOL
	mov ecx, [eax]
	test ecx, ecx
	je d2
	mov ecx, [ecx+8]
	test ecx, ecx
	je d2
	sub ecx, 1C
	mov eax, [ecx+28]
	cmp eax, 01
	je d0
	cmp eax, 06
	jne d1
d0:	mov ecx, [ecx+00000154]
	test ecx, ecx
	je d2
	mov ecx, [ecx+08]
	sub ecx, 1C
b2:	call NO_SYMBOL
	jmp d2

	cmp eax, 02					; nop
	jne d2						; nop
d1:	mov ecx, [ecx+00000158]
	test ecx, ecx
	je d2
	mov ecx, [ecx+08]
	sub ecx, 1C
b3:	call NO_SYMBOL

d2:	pop ebx
	pop esi
	pop edi
	pop ebp
	ret
CameraControlMain_End:

END