INCLUDE <ASMInclude.asm>
INCLUDE <AMTFlags.asm>

public UIHideScreenNotifications
public UIHideScreenNotifications_End
public UIHideScreenNotifications_Bindings

.DATA

UIHideScreenNotifications_Bindings	DWORD		0
bind0								DWORD		b0+2

.CODE

UIHideScreenNotifications:
b0:	test byte ptr ds:[NO_ADDRESS], FLAG0_HIDE_SCREEN_NOTIFICATIONS
	jne d0
	cmp dword ptr [esi+000000E0], 00
	jne d1
d0:	jmp d3
d1:	mov eax, [ebp+0C]
	lea edi, [esp+40]
	mov ecx, [eax]
	mov [edi], ecx
	mov ecx, [eax+04]
	mov [edi+04], ecx
	mov ecx, [eax+08]
	mov [edi+08], ecx
	mov ecx, [eax+0C]
	mov [edi+0C], ecx
	mov ecx, [eax+14]
	mov [edi+14], ecx
	mov ecx, [eax+18]
	mov [edi+18], ecx
	mov ecx, [eax+10]
	cmp dword ptr [esi+000000D4], 01
	je d2
	or ecx, 01
d2:	mov [edi+10], ecx
	nop
UIHideScreenNotifications_End:

d3 = UIHideScreenNotifications+339

END