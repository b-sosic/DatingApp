export interface Message {
  id: number;
  senderId: number;
  senderUsername: string;
  senderPhotoUrl: string;
  recipientId: number;
  recipientUsename: string;
  recipientPhotoUrl: string;
  context: string;
  dateRead?: Date;
  messageSent: Date;
}
