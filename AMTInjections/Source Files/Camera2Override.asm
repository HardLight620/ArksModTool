INCLUDE <ASMInclude.asm>
INCLUDE <AMTFlags.asm>

public Camera2Override
public Camera2Override_End
public Camera2Override_Bindings

.DATA

Camera2Override_Bindings	DWORD		0
bind0						DWORD		b0+1

.CODE

Camera2Override:
	push ebx
	push esi
	push edi
	mov edi, ecx
b0:	mov esi, NO_ADDRESS
	test byte ptr[esi+01], FLAG1_OVERRIDE_SHOOTER_CAMERA
	je d0
	lea ecx, [edi+000000A0]
	movaps xmm0, [esi+30]
	movaps [ecx], xmm0
	mov eax, [esi+40]
	mov [ecx+10], eax
	mov eax, [esi+44]
	mov [ecx+14], eax
	mov eax, [esi+48]
	mov [ecx+30], eax
d0:	mov eax, edi
	pop edi
	pop esi
	pop ebx
	ret
Camera2Override_End:

END