# Generated by Django 3.1.3 on 2021-10-27 01:39

from django.db import migrations


class Migration(migrations.Migration):

    dependencies = [
        ('main', '0006_auto_20211026_2235'),
    ]

    operations = [
        migrations.RemoveField(
            model_name='facturaxxi',
            name='tipo_pago_xxi_id_tipo_pago',
        ),
        migrations.RemoveField(
            model_name='productosxxi',
            name='tipo_pago',
        ),
    ]