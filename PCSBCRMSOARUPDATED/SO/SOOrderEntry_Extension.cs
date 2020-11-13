// Decompiled with JetBrains decompiler
// Type: PX.Objects.SO.SOOrderEntry_Extension
// Assembly: PCSBCRMSOARUPDATED, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 182865F4-07BB-4D2C-9E47-9E96DF45516C
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Vihywod\7ad39fc3ac\Bin\PCSBCRMSOARUPDATED.dll

using PX.Data;
using PX.Objects.CR;
using PX.Objects.EP;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PX.Objects.SO
{
    public class SOOrderEntry_Extension : PXGraphExtension<SOOrderEntry>
    {
        public PXSelect<SOOrder, Where<SOOrder.orderType, Equal<Current<SOOrder.orderType>>, And<SOOrder.orderNbr, Equal<Current<SOOrder.orderNbr>>>>> SDCurrentDocument;

        protected void SOOrder_RowSelected(PXCache cache, PXRowSelectedEventArgs e)
        {
            SOOrder row = (SOOrder)e.Row;
            if (row == null)
                return;
            ((PXSelectBase)this.SDCurrentDocument).AllowSelect = (row.OrderType == "SO");

            //Code To Copy Opportunity_ID from opportunities Screen to Sales Order Screen Done By SD
            //SOOrder current = ((PXSelectBase<SOOrder>)this.Base.Document).Current;
            //if (current.OrderType == "SO")
            //{
            //    using (IEnumerator<PXResult<CRRelation>> enumerator = ((PXSelectBase<CRRelation>)this.Base.RelationsLink).Select(new object[0]).GetEnumerator())
            //    {
            //        while (((IEnumerator)enumerator).MoveNext())
            //        {
            //            CRRelation crRelation = (enumerator.Current);



            //            Guid? refNoteId = crRelation.RefNoteID;
            //            Guid? noteId = current.NoteID;
            //            //if ((refNoteId.HasValue == noteId.HasValue ? (refNoteId.HasValue ? (refNoteId.GetValueOrDefault() == noteId.GetValueOrDefault() ? 1 : 0) : 1) : 0) != 0 && crRelation.Role == "SR")
            //            if (crRelation.Role == "SR")
            //            {
            //                CROpportunity crOpportunity = (PXSelect<CROpportunity, Where<CROpportunity.noteID, Equal<Required<CROpportunity.noteID>>>>.Select(Base, crRelation.TargetNoteID));

            //                if (crOpportunity != null)
            //                {
            //                    ((SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>(current)).UsrOpNum = crOpportunity.OpportunityID;
            //                    break;

            //                }
            //                break;
            //            }
            //        }
            //    }
            //}
            // End of Code

        }

        protected void SOOrder_OwnerID_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOOrder row = (SOOrder)e.Row;
            SOOrderExt extension1 = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>(row);
            EPEmployee epEmployee = PXSelect<EPEmployee, Where<EPEmployee.userID, Equal<Required<EPEmployee.userID>>>>.Select(Base, row.OwnerID);
            if (epEmployee != null)
            {
                BAccountExt extension2 = (BAccountExt)PXCache<BAccount>.GetExtension<BAccountExt>((BAccount)epEmployee);
                // extension1.UsrBusUnit = extension2.UsrBusUnit;
            }
            else
                extension1.UsrBusUnit = "";
        }

        protected void SOOrder_UsrLegalReq_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>((SOOrder)e.Row);
            bool? usrLegalReq = extension.UsrLegalReq;
            bool flag1 = true;
            if (usrLegalReq.GetValueOrDefault() == flag1 && usrLegalReq.HasValue)
                extension.UsrNLegalReq = new bool?(false);
            usrLegalReq = extension.UsrLegalReq;
            bool flag2 = false;
            if (usrLegalReq.GetValueOrDefault() != flag2 || !usrLegalReq.HasValue)
                return;
            extension.UsrNLegalReq = new bool?(true);
        }

        protected void SOOrder_UsrNLegalReq_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>((SOOrder)e.Row);
            bool? usrNlegalReq = extension.UsrNLegalReq;
            bool flag1 = true;
            if (usrNlegalReq.GetValueOrDefault() == flag1 && usrNlegalReq.HasValue)
                extension.UsrLegalReq = new bool?(false);
            usrNlegalReq = extension.UsrNLegalReq;
            bool flag2 = false;
            if (usrNlegalReq.GetValueOrDefault() != flag2 || !usrNlegalReq.HasValue)
                return;
            extension.UsrLegalReq = new bool?(true);
        }

        protected void SOOrder_UsrProjectInsReq_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>((SOOrder)e.Row);
            bool? usrProjectInsReq = extension.UsrProjectInsReq;
            bool flag1 = true;
            if (usrProjectInsReq.GetValueOrDefault() == flag1 && usrProjectInsReq.HasValue)
                extension.UsrNProjectInsReq = new bool?(false);
            usrProjectInsReq = extension.UsrProjectInsReq;
            bool flag2 = false;
            if (usrProjectInsReq.GetValueOrDefault() != flag2 || !usrProjectInsReq.HasValue)
                return;
            extension.UsrNProjectInsReq = new bool?(true);
        }

        protected void SOOrder_UsrNProjectInsReq_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>((SOOrder)e.Row);
            bool? usrNprojectInsReq = extension.UsrNProjectInsReq;
            bool flag1 = true;
            if (usrNprojectInsReq.GetValueOrDefault() == flag1 && usrNprojectInsReq.HasValue)
                extension.UsrProjectInsReq = new bool?(false);
            usrNprojectInsReq = extension.UsrNProjectInsReq;
            bool flag2 = false;
            if (usrNprojectInsReq.GetValueOrDefault() != flag2 || !usrNprojectInsReq.HasValue)
                return;
            extension.UsrProjectInsReq = new bool?(true);
        }

        protected void SOOrder_UsrContractPnlty_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>((SOOrder)e.Row);
            bool? usrContractPnlty = extension.UsrContractPnlty;
            bool flag1 = true;
            if (usrContractPnlty.GetValueOrDefault() == flag1 && usrContractPnlty.HasValue)
                extension.UsrNContractPnlty = new bool?(false);
            usrContractPnlty = extension.UsrContractPnlty;
            bool flag2 = false;
            if (usrContractPnlty.GetValueOrDefault() != flag2 || !usrContractPnlty.HasValue)
                return;
            extension.UsrNContractPnlty = new bool?(true);
        }

        protected void SOOrder_UsrNContractPnlty_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>((SOOrder)e.Row);
            bool? usrNcontractPnlty = extension.UsrNContractPnlty;
            bool flag1 = true;
            if (usrNcontractPnlty.GetValueOrDefault() == flag1 && usrNcontractPnlty.HasValue)
                extension.UsrContractPnlty = new bool?(false);
            usrNcontractPnlty = extension.UsrNContractPnlty;
            bool flag2 = false;
            if (usrNcontractPnlty.GetValueOrDefault() != flag2 || !usrNcontractPnlty.HasValue)
                return;
            extension.UsrContractPnlty = new bool?(true);
        }

        protected void SOOrder_UsrCorrectCstCen_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>((SOOrder)e.Row);
            bool? usrCorrectCstCen = extension.UsrCorrectCstCen;
            bool flag1 = true;
            if (usrCorrectCstCen.GetValueOrDefault() == flag1 && usrCorrectCstCen.HasValue)
                extension.UsrNCorrectCstCen = new bool?(false);
            usrCorrectCstCen = extension.UsrCorrectCstCen;
            bool flag2 = false;
            if (usrCorrectCstCen.GetValueOrDefault() != flag2 || !usrCorrectCstCen.HasValue)
                return;
            extension.UsrNCorrectCstCen = new bool?(true);
        }

        protected void SOOrder_UsrNCorrectCstCen_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>((SOOrder)e.Row);
            bool? usrNcorrectCstCen = extension.UsrNCorrectCstCen;
            bool flag1 = true;
            if (usrNcorrectCstCen.GetValueOrDefault() == flag1 && usrNcorrectCstCen.HasValue)
                extension.UsrCorrectCstCen = new bool?(false);
            usrNcorrectCstCen = extension.UsrNCorrectCstCen;
            bool flag2 = false;
            if (usrNcorrectCstCen.GetValueOrDefault() != flag2 || !usrNcorrectCstCen.HasValue)
                return;
            extension.UsrCorrectCstCen = new bool?(true);
        }

        protected void SOOrder_UsrCorrectPOValue_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>((SOOrder)e.Row);
            bool? usrCorrectPoValue = extension.UsrCorrectPOValue;
            bool flag1 = true;
            if (usrCorrectPoValue.GetValueOrDefault() == flag1 && usrCorrectPoValue.HasValue)
                extension.UsrNCorrectPOValue = new bool?(false);
            usrCorrectPoValue = extension.UsrCorrectPOValue;
            bool flag2 = false;
            if (usrCorrectPoValue.GetValueOrDefault() != flag2 || !usrCorrectPoValue.HasValue)
                return;
            extension.UsrNCorrectPOValue = new bool?(true);
        }

        protected void SOOrder_UsrNCorrectPOValue_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>((SOOrder)e.Row);
            bool? usrNcorrectPoValue = extension.UsrNCorrectPOValue;
            bool flag1 = true;
            if (usrNcorrectPoValue.GetValueOrDefault() == flag1 && usrNcorrectPoValue.HasValue)
                extension.UsrCorrectPOValue = new bool?(false);
            usrNcorrectPoValue = extension.UsrNCorrectPOValue;
            bool flag2 = false;
            if (usrNcorrectPoValue.GetValueOrDefault() != flag2 || !usrNcorrectPoValue.HasValue)
                return;
            extension.UsrCorrectPOValue = new bool?(true);
        }

        protected void SOOrder_UsrCorrectIncoterm_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>((SOOrder)e.Row);
            bool? usrCorrectIncoterm = extension.UsrCorrectIncoterm;
            bool flag1 = true;
            if (usrCorrectIncoterm.GetValueOrDefault() == flag1 && usrCorrectIncoterm.HasValue)
                extension.UsrNCorrectIncoterm = new bool?(false);
            usrCorrectIncoterm = extension.UsrCorrectIncoterm;
            bool flag2 = false;
            if (usrCorrectIncoterm.GetValueOrDefault() != flag2 || !usrCorrectIncoterm.HasValue)
                return;
            extension.UsrNCorrectIncoterm = new bool?(true);
        }

        protected void SOOrder_UsrNCorrectIncoterm_FieldUpdated(
          PXCache cache,
          PXFieldUpdatedEventArgs e)
        {
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>((SOOrder)e.Row);
            bool? ncorrectIncoterm = extension.UsrNCorrectIncoterm;
            bool flag1 = true;
            if (ncorrectIncoterm.GetValueOrDefault() == flag1 && ncorrectIncoterm.HasValue)
                extension.UsrCorrectIncoterm = new bool?(false);
            ncorrectIncoterm = extension.UsrNCorrectIncoterm;
            bool flag2 = false;
            if (ncorrectIncoterm.GetValueOrDefault() != flag2 || !ncorrectIncoterm.HasValue)
                return;
            extension.UsrCorrectIncoterm = new bool?(true);
        }

        protected void SOOrder_UsrCorrectPayTerm_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>((SOOrder)e.Row);
            bool? usrCorrectPayTerm = extension.UsrCorrectPayTerm;
            bool flag1 = true;
            if (usrCorrectPayTerm.GetValueOrDefault() == flag1 && usrCorrectPayTerm.HasValue)
                extension.UsrNCorrectPayTerm = new bool?(false);
            usrCorrectPayTerm = extension.UsrCorrectPayTerm;
            bool flag2 = false;
            if (usrCorrectPayTerm.GetValueOrDefault() != flag2 || !usrCorrectPayTerm.HasValue)
                return;
            extension.UsrNCorrectPayTerm = new bool?(true);
        }

        protected void SOOrder_UsrNCorrectPayTerm_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>((SOOrder)e.Row);
            bool? usrNcorrectPayTerm = extension.UsrNCorrectPayTerm;
            bool flag1 = true;
            if (usrNcorrectPayTerm.GetValueOrDefault() == flag1 && usrNcorrectPayTerm.HasValue)
                extension.UsrCorrectPayTerm = new bool?(false);
            usrNcorrectPayTerm = extension.UsrNCorrectPayTerm;
            bool flag2 = false;
            if (usrNcorrectPayTerm.GetValueOrDefault() != flag2 || !usrNcorrectPayTerm.HasValue)
                return;
            extension.UsrCorrectPayTerm = new bool?(true);
        }

        protected void SOOrder_UsrCorrectQtRefNo_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>((SOOrder)e.Row);
            bool? usrCorrectQtRefNo = extension.UsrCorrectQtRefNo;
            bool flag1 = true;
            if (usrCorrectQtRefNo.GetValueOrDefault() == flag1 && usrCorrectQtRefNo.HasValue)
                extension.UsrNCorrectQtRefNo = new bool?(false);
            usrCorrectQtRefNo = extension.UsrCorrectQtRefNo;
            bool flag2 = false;
            if (usrCorrectQtRefNo.GetValueOrDefault() != flag2 || !usrCorrectQtRefNo.HasValue)
                return;
            extension.UsrNCorrectQtRefNo = new bool?(true);
        }

        protected void SOOrder_UsrNCorrectQtRefNo_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>((SOOrder)e.Row);
            bool? usrNcorrectQtRefNo = extension.UsrNCorrectQtRefNo;
            bool flag1 = true;
            if (usrNcorrectQtRefNo.GetValueOrDefault() == flag1 && usrNcorrectQtRefNo.HasValue)
                extension.UsrCorrectQtRefNo = new bool?(false);
            usrNcorrectQtRefNo = extension.UsrNCorrectQtRefNo;
            bool flag2 = false;
            if (usrNcorrectQtRefNo.GetValueOrDefault() != flag2 || !usrNcorrectQtRefNo.HasValue)
                return;
            extension.UsrCorrectQtRefNo = new bool?(true);
        }

        protected void SOOrder_UsrSpecialInst_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>((SOOrder)e.Row);
            bool? usrSpecialInst = extension.UsrSpecialInst;
            bool flag1 = true;
            if (usrSpecialInst.GetValueOrDefault() == flag1 && usrSpecialInst.HasValue)
                extension.UsrNSpecialInst = new bool?(false);
            usrSpecialInst = extension.UsrSpecialInst;
            bool flag2 = false;
            if (usrSpecialInst.GetValueOrDefault() != flag2 || !usrSpecialInst.HasValue)
                return;
            extension.UsrNSpecialInst = new bool?(true);
        }

        protected void SOOrder_UsrNSpecialInst_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>((SOOrder)e.Row);
            bool? usrNspecialInst = extension.UsrNSpecialInst;
            bool flag1 = true;
            if (usrNspecialInst.GetValueOrDefault() == flag1 && usrNspecialInst.HasValue)
                extension.UsrSpecialInst = new bool?(false);
            usrNspecialInst = extension.UsrNSpecialInst;
            bool flag2 = false;
            if (usrNspecialInst.GetValueOrDefault() != flag2 || !usrNspecialInst.HasValue)
                return;
            extension.UsrSpecialInst = new bool?(true);
        }

        [PXOverride]
        public void Persist(SOOrderEntry_Extension.PersistDelegate baseMethod)
        {
            SOOrder current = ((PXSelectBase<SOOrder>)this.Base.Document).Current;
            if (current == null)
            {
                baseMethod();
            }
            else
            {
                SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>(current);
                if (current.OrderType == "SO")
                {
                    if (this.ValidateControls())
                    {
                        ((PXSelectBase<SOOrder>)this.Base.CurrentDocument).Ask("Error", "Can't Save...! Please Fill Order Acknowledgement", (MessageButtons)0, (MessageIcon)1);
                    }
                    else
                    {
                        using (IEnumerator<PXResult<CRRelation>> enumerator = ((PXSelectBase<CRRelation>)this.Base.RelationsLink).Select(new object[0]).GetEnumerator())
                        {
                            while (((IEnumerator)enumerator).MoveNext())

                            {
                                CRRelation crRelation = (enumerator.Current);


                                Guid? refNoteId = crRelation.RefNoteID;
                                Guid? noteId = current.NoteID;
                                if ((refNoteId.HasValue == noteId.HasValue ? (refNoteId.HasValue ? (refNoteId.GetValueOrDefault() == noteId.GetValueOrDefault() ? 1 : 0) : 1) : 0) != 0 && crRelation.Role == "SR")
                                {
                                    CROpportunity crOpportunity = (PXSelect<CROpportunity, Where<CROpportunity.noteID, Equal<Required<CROpportunity.noteID>>>>.Select(Base, crRelation.TargetNoteID));

                                    if (crOpportunity != null)
                                    {
                                        ((SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>(current)).UsrOpNum = crOpportunity.OpportunityID;

                                        break;
                                    }
                                    break;
                                }
                            }
                        }
                        baseMethod();
                    }
                }
                else
                {
                    using (IEnumerator<PXResult<CRRelation>> enumerator = ((PXSelectBase<CRRelation>)this.Base.RelationsLink).Select(new object[0]).GetEnumerator())
                    {
                        while (((IEnumerator)enumerator).MoveNext())
                        {
                            CRRelation crRelation = (enumerator.Current);



                            Guid? refNoteId = crRelation.RefNoteID;
                            Guid? noteId = current.NoteID;
                            if ((refNoteId.HasValue == noteId.HasValue ? (refNoteId.HasValue ? (refNoteId.GetValueOrDefault() == noteId.GetValueOrDefault() ? 1 : 0) : 1) : 0) != 0 && crRelation.Role == "SR")
                            {
                                CROpportunity crOpportunity = (PXSelect<CROpportunity, Where<CROpportunity.noteID, Equal<Required<CROpportunity.noteID>>>>.Select(Base, crRelation.TargetNoteID));

                                if (crOpportunity != null)
                                {
                                    ((SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>(current)).UsrOpNum = crOpportunity.OpportunityID;
                                    break;
                                }
                                break;
                            }
                        }
                    }
                    baseMethod();
                }
            }
        }

        protected bool ValidateControls()
        {
            bool flag1 = false;
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>(((PXSelectBase<SOOrder>)this.Base.Document).Current);
            bool? nullable = extension.UsrLegalReq;
            bool flag2 = false;
            if ((nullable.GetValueOrDefault() == flag2 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
            {
                nullable = extension.UsrNLegalReq;
                bool flag3 = false;
                if ((nullable.GetValueOrDefault() == flag3 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
                    goto label_19;
            }
            nullable = extension.UsrProjectInsReq;
            bool flag4 = false;
            if ((nullable.GetValueOrDefault() == flag4 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
            {
                nullable = extension.UsrNProjectInsReq;
                bool flag3 = false;
                if ((nullable.GetValueOrDefault() == flag3 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
                    goto label_19;
            }
            nullable = extension.UsrContractPnlty;
            bool flag5 = false;
            if ((nullable.GetValueOrDefault() == flag5 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
            {
                nullable = extension.UsrNContractPnlty;
                bool flag3 = false;
                if ((nullable.GetValueOrDefault() == flag3 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
                    goto label_19;
            }
            nullable = extension.UsrCorrectCstCen;
            bool flag6 = false;
            if ((nullable.GetValueOrDefault() == flag6 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
            {
                nullable = extension.UsrNCorrectCstCen;
                bool flag3 = false;
                if ((nullable.GetValueOrDefault() == flag3 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
                    goto label_19;
            }
            nullable = extension.UsrCorrectPOValue;
            bool flag7 = false;
            if ((nullable.GetValueOrDefault() == flag7 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
            {
                nullable = extension.UsrNCorrectPOValue;
                bool flag3 = false;
                if ((nullable.GetValueOrDefault() == flag3 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
                    goto label_19;
            }
            nullable = extension.UsrCorrectIncoterm;
            bool flag8 = false;
            if ((nullable.GetValueOrDefault() == flag8 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
            {
                nullable = extension.UsrNCorrectIncoterm;
                bool flag3 = false;
                if ((nullable.GetValueOrDefault() == flag3 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
                    goto label_19;
            }
            nullable = extension.UsrCorrectPayTerm;
            bool flag9 = false;
            if ((nullable.GetValueOrDefault() == flag9 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
            {
                nullable = extension.UsrNCorrectPayTerm;
                bool flag3 = false;
                if ((nullable.GetValueOrDefault() == flag3 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
                    goto label_19;
            }
            nullable = extension.UsrCorrectQtRefNo;
            bool flag10 = false;
            if ((nullable.GetValueOrDefault() == flag10 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
            {
                nullable = extension.UsrNCorrectQtRefNo;
                bool flag3 = false;
                if ((nullable.GetValueOrDefault() == flag3 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
                    goto label_19;
            }
            nullable = extension.UsrSpecialInst;
            bool flag11 = false;
            int num;
            if ((nullable.GetValueOrDefault() == flag11 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
            {
                nullable = extension.UsrNSpecialInst;
                bool flag3 = false;
                num = nullable.GetValueOrDefault() == flag3 ? (nullable.HasValue ? 1 : 0) : 0;
                goto label_20;
            }
            else
            {
                num = 0;
                goto label_20;
            }
            label_19:
            num = 1;
            label_20:
            if (num != 0)
                flag1 = true;
            return flag1;
        }

        protected virtual IEnumerable currentDocument(PXCache cache)
        {
            SOOrder current = ((PXSelectBase<SOOrder>)this.Base.Document).Current;
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>(current);
            PXResultset<SOOrder> pxResultset = new PXResultset<SOOrder>();
            if (current.OrderType == "SO")
            {
                bool? nullable = extension.UsrLegalReq;
                bool flag1 = false;
                int num1;
                if ((nullable.GetValueOrDefault() == flag1 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
                {
                    nullable = extension.UsrNLegalReq;
                    bool flag2 = false;
                    num1 = nullable.GetValueOrDefault() == flag2 ? (nullable.HasValue ? 1 : 0) : 0;
                }
                else
                    num1 = 0;
                if (num1 != 0)
                {
                    ((PXSelectBase)this.SDCurrentDocument).Cache.RaiseExceptionHandling<SOOrderExt.usrNLegalReq>((object)current, (object)extension.UsrNLegalReq, (Exception)new PXSetPropertyException(ExceptionText, (PXErrorLevel)4));
                }
                else
                {
                    nullable = extension.UsrProjectInsReq;
                    bool flag2 = false;
                    int num2;
                    if ((nullable.GetValueOrDefault() == flag2 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
                    {
                        nullable = extension.UsrNProjectInsReq;
                        bool flag3 = false;
                        num2 = nullable.GetValueOrDefault() == flag3 ? (nullable.HasValue ? 1 : 0) : 0;
                    }
                    else
                        num2 = 0;
                    if (num2 != 0)
                    {
                        ((PXSelectBase)this.SDCurrentDocument).Cache.RaiseExceptionHandling<SOOrderExt.usrNProjectInsReq>
                            ((object)current, (object)extension.UsrNProjectInsReq,
                            (Exception)new PXSetPropertyException(ExceptionText, (PXErrorLevel)4));
                    }
                    else
                    {
                        nullable = extension.UsrContractPnlty;
                        bool flag3 = false;
                        int num3;
                        if ((nullable.GetValueOrDefault() == flag3 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
                        {
                            nullable = extension.UsrNContractPnlty;
                            bool flag4 = false;
                            num3 = nullable.GetValueOrDefault() == flag4 ? (nullable.HasValue ? 1 : 0) : 0;
                        }
                        else
                            num3 = 0;
                        if (num3 != 0)
                        {
                            ((PXSelectBase)this.SDCurrentDocument).Cache.RaiseExceptionHandling<SOOrderExt.usrNContractPnlty>((object)current, (object)extension.UsrNContractPnlty, (Exception)new PXSetPropertyException(ExceptionText, (PXErrorLevel)4));
                        }
                        else
                        {
                            nullable = extension.UsrCorrectCstCen;
                            bool flag4 = false;
                            int num4;
                            if ((nullable.GetValueOrDefault() == flag4 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
                            {
                                nullable = extension.UsrNCorrectCstCen;
                                bool flag5 = false;
                                num4 = nullable.GetValueOrDefault() == flag5 ? (nullable.HasValue ? 1 : 0) : 0;
                            }
                            else
                                num4 = 0;
                            if (num4 != 0)
                            {
                                ((PXSelectBase)this.SDCurrentDocument).Cache.RaiseExceptionHandling<SOOrderExt.usrNCorrectCstCen>((object)current,
                                    (object)extension.UsrNCorrectCstCen,
                                    (Exception)new PXSetPropertyException(ExceptionText, (PXErrorLevel)4));
                            }
                            else
                            {
                                nullable = extension.UsrCorrectPOValue;
                                bool flag5 = false;
                                int num5;
                                if ((nullable.GetValueOrDefault() == flag5 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
                                {
                                    nullable = extension.UsrNCorrectPOValue;
                                    bool flag6 = false;
                                    num5 = nullable.GetValueOrDefault() == flag6 ? (nullable.HasValue ? 1 : 0) : 0;
                                }
                                else
                                    num5 = 0;
                                if (num5 != 0)
                                {
                                    ((PXSelectBase)this.SDCurrentDocument).Cache.RaiseExceptionHandling<SOOrderExt.usrNCorrectPOValue>((object)current, (object)extension.UsrNCorrectPOValue, (Exception)new PXSetPropertyException(ExceptionText, (PXErrorLevel)4));
                                }
                                else
                                {
                                    nullable = extension.UsrCorrectIncoterm;
                                    bool flag6 = false;
                                    int num6;
                                    if ((nullable.GetValueOrDefault() == flag6 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
                                    {
                                        nullable = extension.UsrNCorrectIncoterm;
                                        bool flag7 = false;
                                        num6 = nullable.GetValueOrDefault() == flag7 ? (nullable.HasValue ? 1 : 0) : 0;
                                    }
                                    else
                                        num6 = 0;
                                    if (num6 != 0)
                                    {
                                        ((PXSelectBase)this.SDCurrentDocument).Cache.RaiseExceptionHandling<SOOrderExt.usrNCorrectIncoterm>((object)current, (object)extension.UsrNCorrectIncoterm, (Exception)new PXSetPropertyException(ExceptionText, (PXErrorLevel)4));
                                    }
                                    else
                                    {
                                        nullable = extension.UsrCorrectPayTerm;
                                        bool flag7 = false;
                                        int num7;
                                        if ((nullable.GetValueOrDefault() == flag7 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
                                        {
                                            nullable = extension.UsrNCorrectPayTerm;
                                            bool flag8 = false;
                                            num7 = nullable.GetValueOrDefault() == flag8 ? (nullable.HasValue ? 1 : 0) : 0;
                                        }
                                        else
                                            num7 = 0;

                                        if (num7 != 0)
                                        {
                                            ((PXSelectBase)this.SDCurrentDocument).Cache.RaiseExceptionHandling<SOOrderExt.usrNCorrectPayTerm>((object)current, (object)extension.UsrNCorrectPayTerm, (Exception)new PXSetPropertyException(ExceptionText, (PXErrorLevel)4));
                                        }
                                        else
                                        {
                                            nullable = extension.UsrCorrectQtRefNo;
                                            bool flag8 = false;
                                            int num8;
                                            if ((nullable.GetValueOrDefault() == flag8 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
                                            {
                                                nullable = extension.UsrNCorrectQtRefNo;
                                                bool flag9 = false;
                                                num8 = nullable.GetValueOrDefault() == flag9 ? (nullable.HasValue ? 1 : 0) : 0;
                                            }
                                            else
                                                num8 = 0;
                                            if (num8 != 0)
                                            {
                                                ((PXSelectBase)this.SDCurrentDocument).Cache.RaiseExceptionHandling<SOOrderExt.usrNCorrectQtRefNo>((object)current, (object)extension.UsrNCorrectQtRefNo, (Exception)new PXSetPropertyException(ExceptionText, (PXErrorLevel)4));
                                            }
                                            else
                                            {
                                                nullable = extension.UsrSpecialInst;
                                                bool flag9 = false;
                                                int num9;
                                                if ((nullable.GetValueOrDefault() == flag9 ? (nullable.HasValue ? 1 : 0) : 0) != 0)
                                                {
                                                    nullable = extension.UsrNSpecialInst;
                                                    bool flag10 = false;
                                                    num9 = nullable.GetValueOrDefault() == flag10 ? (nullable.HasValue ? 1 : 0) : 0;
                                                }
                                                else
                                                    num9 = 0;
                                                if (num9 != 0)
                                                    ((PXSelectBase)this.SDCurrentDocument).Cache.RaiseExceptionHandling<SOOrderExt.usrNSpecialInst>((object)current, (object)extension.UsrNSpecialInst, (Exception)new PXSetPropertyException(ExceptionText, (PXErrorLevel)4));
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            pxResultset.Add(new PXResult<SOOrder>(current));
            return (IEnumerable)pxResultset;
        }

        public string ExceptionText = "Pair of [YES/NO] Checkbox is not marked in Order Acknowledgement Tab. ";
        //public class ExceptionText : PX.Data.BQL.BqlString.Constant<_CC>
        //{
        //    public ExceptionText() : base("Pair of [YES/NO] Checkbox is not marked in Order Acknowledgement Tab. ")
        //    {
        //    }
        //}
        public delegate void PersistDelegate();
    }
}
