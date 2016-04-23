INCLUDE <ASMInclude.asm>
INCLUDE <AMTFlags.asm>

public UIHideECodes
public UIHideECodes_End
public UIHideECodes_Bindings

.DATA

UIHideECodes_Bindings	DWORD		0
bind0					DWORD		b0+2

.CODE

UIHideECodes:
	mov ecx, [edi+esi*4+24]
b0:	test byte ptr ds:[NO_ADDRESS], FLAG0_HIDE_ECODES
	je d0
	mov edx, [ecx+58]
	mov [edx+40], 0FFFFFFFF
	mov [edx+58], 00000000
	mov eax, [ecx]
	call dword ptr [eax+04]
	jmp d2
d0:	cmp dword ptr [ebp+0C], 2E
	ja d1
	nop
	nop
UIHideECodes_End:

d1 = UIHideECodes+6A0
d2 = UIHideECodes+6D8

END