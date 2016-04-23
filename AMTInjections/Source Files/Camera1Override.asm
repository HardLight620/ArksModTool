INCLUDE <ASMInclude.asm>
INCLUDE <AMTFlags.asm>

public Camera1Override
public Camera1Override_End
public Camera1Override_Bindings

.DATA

Camera1Override_Bindings	DWORD		0
bind0						DWORD		b0+1

.CODE

Camera1Override:
	push ebx
	push esi
	push edi
	mov edi, ecx
b0:	mov esi, NO_ADDRESS
	test byte ptr[esi+01], FLAG1_OVERRIDE_NORMAL_CAMERA
	je d0
	lea ecx, [edi+000000A0]
	mov eax, [esi+20]
	mov [ecx], eax
	mov eax, [esi+24]
	mov [ecx+04], eax
	mov eax, [esi+28]
	mov [ecx+08], eax
	mov [ecx+0C], eax
	mov [ecx+10], eax
	mov eax, [esi+2C]
	mov [edi+00000114], eax
	lea esi, [edi+00000150]
	mov edx, [esi+34]
	mov [esi+34], eax
	cmp eax, edx
	je d0
	mov ebx, [esi+10]
	mov [esi+10], 00000000
	mov ecx, edi
	mov edx, [ecx]
	push 00
	call dword ptr[edx+14]
	mov [esi+10], ebx
d0:	mov eax, edi
	pop edi
	pop esi
	pop ebx
	ret
Camera1Override_End:

END