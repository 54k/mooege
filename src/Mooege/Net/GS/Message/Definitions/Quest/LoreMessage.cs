/*
 * Copyright (C) 2011 mooege project
 *
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

using System.Text;

namespace Mooege.Net.GS.Message.Definitions.Quest
{
/* TODO: FIXME
    [Message(new[] {Opcodes.PlayLoreImmediately,Opcodes.PlayLoreWithButton})]
    [Message(Opcodes.LoreMessage)]
    public class LoreMessage : GameMessage
    {
        public int LoreSNOId;

        public override void Parse(GameBitBuffer buffer)
        {
            LoreSNOId = buffer.ReadInt(32);
        }

        public override void Encode(GameBitBuffer buffer)
        {
            buffer.WriteInt(32, LoreSNOId);
        }

        public override void AsText(StringBuilder b, int pad)
        {
            b.Append(' ', pad);
            b.AppendLine("LoreMessage:");
            b.Append(' ', pad++);
            b.AppendLine("{");
            b.Append(' ', pad); b.AppendLine("LoreSNOId: 0x" + LoreSNOId.ToString("X8"));
            b.Append(' ', --pad);
            b.AppendLine("}");
        }
    }
*/
}