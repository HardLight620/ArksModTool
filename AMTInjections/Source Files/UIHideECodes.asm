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
	mov ecx, [esp+08]
	mov [ecx+000000CC],00000001
b0:	test byte ptr ds:[NO_ADDRESS], FLAG0_HIDE_ECODES
	je d0
	mov ecx, [ecx+44]
	mov ecx, [ecx+58]
	mov [ecx+40], 0FFFFFFFF
	mov [ecx+58], 00000000
	mov eax, [ecx]
	call dword ptr[eax+04]
	mov eax, [esp+04]
	mov ecx, [esp+08]
	mov ecx, [ecx+eax*4+24]
	mov ecx, [ecx+58]
	mov [ecx+40], 0FFFFFFFF
	mov [ecx+58], 00000000
	mov eax, [ecx]
	call dword ptr[eax+04]
d0:	ret 0008
UIHideECodes_End:

END