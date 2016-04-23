INCLUDE <ASMInclude.asm>

public CameraLandingOverride
public CameraLandingOverride_End
public CameraLandingOverride_Bindings

.DATA

CameraLandingOverride_Bindings	DWORD		0
bind0							DWORD		b0+1

.CODE

CameraLandingOverride:
	test eax, eax
	je d0
	mov ecx, eax
b0:	call NO_SYMBOL			; Camera1Override
	add eax, 20
	push eax
	xor eax, eax
	lea ecx, [esp+000000E0]
	mov [ecx], eax
CameraLandingOverride_End:

d0 = CameraLandingOverride+21

END