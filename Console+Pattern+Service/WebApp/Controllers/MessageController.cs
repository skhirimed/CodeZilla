using Domain.Entities;
using Pattern;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class MessageController : Controller
    {
        MessageService messageService = new MessageService();
        AccountService accountService = new AccountService();
        // GET: Message
        public ActionResult Index()
        {
            
            return View(messageService.GetMany(m => m.AccountToID==1));
            
        }

        // GET: Message/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Message/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Message/Create
        [HttpPost]
        public ActionResult Create(MessageView message)
        {
            if (accountService.Get(a => a.Login == message.LoginDestinataire)!=null)
            {
                Message msg = new Message();
                msg.AccountFromID = 1;
                msg.AccountToID = accountService.Get(a => a.Login == message.LoginDestinataire).AccountID;
                msg.Text = message.Text;
                //msg.From = accountService.GetById(1);
                //msg.To = accountService.GetById(message.AccountToID);

                messageService.Add(msg);
                messageService.Commit();
                return RedirectToAction("Index");
            }
            else
            {
                return Content("<script language='javascript' type='text/javascript'>alert('User "+message.LoginDestinataire+ " not found');window.location.href='http://localhost:2014/message/Create';</script>");
            }
           

        }

        // GET: Message/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Message/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Message/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Message/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
